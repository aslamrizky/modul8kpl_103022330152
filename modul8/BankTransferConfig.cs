using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8
{
    class BankTransferConfig
    {
        public String lang { get; set; }
        public transfer transfer { get; set; }
        public String[] methods { get; set; }
        public confirmation confirmation { get; set; }
        public void read()
        {
            String filePath = "bank_transfer_config.json";
            String jsonString = File.ReadAllText(filePath);
            BankTransferConfig config = JsonSerializer.Deserialize<BankTransferConfig>(jsonString);
            this.lang = config.lang;
            this.transfer = config.transfer;
            this.methods = config.methods;
            this.confirmation = config.confirmation;
        }

        public void ubahBahasa(String lang, BankTransferConfig config)
        {
            String filePath = "bank_transfer_config.json";
            if (lang == "en")
            {
                config.lang = "en";
            }
            else if (lang == "id")
            {
                config.lang = "id";
            }
        }
    }

    public class transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }

    }
    public class confirmation
    {
        public String en { get; set; }
        public String id { get; set; }
    }
}
