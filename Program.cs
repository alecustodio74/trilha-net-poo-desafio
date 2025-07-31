using DesafioPOO.Models;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Teste com iPhone:");
        Smartphone iphone = new Iphone("99999-9999", "iPhone 14", "1234567890", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTeste com Nokia:");
        Smartphone nokia = new Nokia("88888-8888", "Nokia Tijolinho", "0987654321", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");
    }
}
