using DesafioPOO.Models;
using SitemaCelulares.Models;

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia("123456", "Nokia Model X", "111111111111111", "64");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nCelular iPhone");
Smartphone iphone = new Iphone("654321", "iPhone 13", "222222222222222", "128");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");