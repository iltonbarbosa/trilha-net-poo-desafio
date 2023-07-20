using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("8732-9012", "12", "1212121212", 64);
Nokia nokia = new Nokia("98474-9090", "modelo 2", "54545454", 128);

Console.WriteLine("Testando smartphone Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("Testando smartphone Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");


