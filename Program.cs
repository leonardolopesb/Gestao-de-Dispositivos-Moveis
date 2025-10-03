using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("81 994824695", "Nokia 3310", "IMEI123456789", 16);

nokia.Ligar();
nokia.ExibirInfo();
nokia.InstalarAplicativo("Facebook");
nokia.EnviarMensagem("11 987654321", "Olá, amigo do IPhone!");
nokia.Desligar();

Console.WriteLine("\nSmartphone iPhone:");
Iphone iphone = new Iphone("11 987654321", "iPhone 13", "IMEI987654321", 128);

iphone.Ligar();
iphone.VerificarMemoria();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("TikTok");
iphone.ReceberLigacao();
iphone.EnviarMensagem("81 994824695", "Olá, amigo do Nokia!");
iphone.Desligar();

Console.WriteLine("\nSmartphone Samsung:");
Samsung samsung = new Samsung("21 998765432", "Samsung Galaxy S21", "IMEI192837465", 256);
samsung.Ligar();
samsung.ExibirInfo();
samsung.VerificarMemoria();
samsung.InstalarAplicativo("WhatsApp");
samsung.InstalarAplicativo("YouTube");
samsung.ReceberLigacao();
samsung.Desligar();