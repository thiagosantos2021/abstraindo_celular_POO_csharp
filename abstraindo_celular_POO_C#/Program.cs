using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia(numero: "984212491", modelo: "Modelo 1", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");

Console.WriteLine("\n");

Console.WriteLine("Smartpone iPhone: ");
Smartphone iphone = new Iphone(numero: "983039538", modelo: "Modelo 2", imei: "987654321", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhasApp");