using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("123", "1", "74", 5);
Smartphone nokia = new Nokia("852", "1", "85", 1);


iphone.Ligar();
nokia.ReceberLigacao();
iphone.InstalarAplicativo("google");
nokia.InstalarAplicativo("facebook");