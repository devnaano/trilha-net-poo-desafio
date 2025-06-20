using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Utilizando dispositivo da Apple");
Smartphone iPhone = new Iphone(numero: "12345", modelo: "iPhone 14", imei: "1a561e651", memoria: 128);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Instagram");


Console.WriteLine("\n");


Console.WriteLine("Utilizando dispositivo da Nokia");
Smartphone nokia = new Nokia(numero: "67890", modelo: "Nokia TIJOLÃO", imei: "5b848c654", memoria: 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");