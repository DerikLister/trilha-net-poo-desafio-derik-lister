using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("1188888880", "Nokia tijolao", "1234576", 12);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("ZipZop");
        nokia.Informações();

        Console.WriteLine();

        Smartphone iphone = new Iphone("11958858366", "iPhone11", "987654321", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Apple Store");
        iphone.Informações();


        Console.ReadLine();
    }
}
