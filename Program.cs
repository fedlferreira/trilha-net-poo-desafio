using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new("12345", "Maça", "abc", 512);
Console.WriteLine($"{iphone.Numero}, {iphone.Modelo}, {iphone.IMEI}, {iphone.Memoria}");
iphone.InstalarAplicativo("Iphone google maps");
iphone.Ligar();

Nokia nokia = new("54321", "Tijolao", "bca", 256);

Console.WriteLine($"{nokia.Numero}, {nokia.Modelo}, {nokia.IMEI}, {nokia.Memoria}");
nokia.InstalarAplicativo("Nokia google maps");
nokia.ReceberLigacao();
nokia.Ligar();