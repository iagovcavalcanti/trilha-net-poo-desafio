using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia(numero: "81999292929", modelo: "Modelo Nokia pro", imei: "123456789", memoria: 128);
        Iphone iphone = new Iphone(numero: "81999991234", modelo: "Modelo Iphone 15 Pro Max", imei: "12121212", memoria: 250);

        Console.WriteLine("Smartphone Nokia");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        nokia.InstalarAplicativo("Facebook");
        nokia.ListarAplicativos();

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        iphone.ListarAplicativos();
    }
}