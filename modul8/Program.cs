using System.Text.Json;
using modul8;

class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        config.read();
        config.ubahBahasa(config.lang, config);
        if (config.lang == "en")
        {
            Console.WriteLine("Current Language : English");
            Console.WriteLine("Transfer :");
            int uang = int.Parse(Console.ReadLine());
            int totalbiaya;
            if (uang < config.transfer.threshold)
            {
                totalbiaya = uang + config.transfer.low_fee;
                Console.WriteLine("Low Fee : " + config.transfer.low_fee);
            }
            else
            {
                totalbiaya = uang + config.transfer.high_fee;
                Console.WriteLine("High Fee : " + config.transfer.high_fee);
            }
            Console.WriteLine("Total Transfer : " + totalbiaya);
            Console.WriteLine("Select Transfer Method: ");
            for (int i = 0; i < config.methods.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + config.methods[i]);
            }
            Console.WriteLine("Please Type " + config.confirmation.en + " to confirm the transfer");
            if (Console.ReadLine() == config.confirmation.en)
            {
                Console.WriteLine("Transfer Success");
            }
            else
            {
                Console.WriteLine("Transfer Failed");
            }
        } else if (config.lang == "id") {
        {
            Console.WriteLine("Bahasa Utama : Indonesia");
            Console.WriteLine("Transfer :");
            int uang = int.Parse(Console.ReadLine());
            int totalbiaya;
            if (uang < config.transfer.threshold)
            {
                totalbiaya = uang + config.transfer.low_fee;
                Console.WriteLine("Low Fee : " + config.transfer.low_fee);
            }
            else
            {
                totalbiaya = uang + config.transfer.high_fee;
                Console.WriteLine("High Fee : " + config.transfer.high_fee);
            }
            Console.WriteLine("Total Transfer : " + totalbiaya);
            Console.WriteLine("Pilih Transfer Method: ");
            for (int i = 0; i < config.methods.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + config.methods[i]);
            }
            Console.WriteLine("Ketik  " + config.confirmation.en + " untuk konfirmasi transfer");
            if (Console.ReadLine() == config.confirmation.en)
            {
                Console.WriteLine("Transfer sukses");
            }
            else
            {
                Console.WriteLine("Transfer gagal");
            }
        }
    }
    }
}
