using Desafio_Unidade.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
nokia.DemonstratConfiguracoesSmartphone();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "987654", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.DemonstratConfiguracoesSmartphone();