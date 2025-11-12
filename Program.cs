using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 1", imei: "1", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.Infos();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "789", modelo: "Iphone 1", imei: "2", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.Infos();