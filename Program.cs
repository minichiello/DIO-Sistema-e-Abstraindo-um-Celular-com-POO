using DesafioPOO.Models;

Smartphone nokia = new Nokia("12312", "modelo 2", "1919239129", 128);
nokia.InstalarAplicativo("WhatsAPP");
nokia.Ligar();
nokia.ReceberLigacao();

Smartphone iphone = new Iphone("12312312","iphone 15","1209129090", 256);
iphone.InstalarAplicativo("Waze");
iphone.Ligar();
iphone.ReceberLigacao();


// TODO: Realizar os testes com as classes Nokia e Iphone