using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("123456", "Nokia Modelo X", "11111111111111", 64);
        Iphone iphone = new Iphone("654321", "iPhone Modelo Y", "2222222222222", 128);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}