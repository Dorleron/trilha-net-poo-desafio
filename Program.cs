using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111222333", memoria: 16);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");

        Iphone iphone = new Iphone(numero: "789012", modelo: "iPhone 13", imei: "444555666", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}
