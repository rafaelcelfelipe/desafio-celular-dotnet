using DesafioPOO.Models;

Nokia nokiaSmartphone = new Nokia(numero: "999999999", modelo: "Nokia 1", imei: "123456789", memoria: 64);
Iphone iphoneSmartphone = new Iphone(numero: "888888888", modelo: "Iphone 12", imei: "987654321", memoria: 128);

nokiaSmartphone.Ligar();
nokiaSmartphone.ReceberLigacao();
nokiaSmartphone.InstalarAplicativo("Whatsapp");

iphoneSmartphone.Ligar();
iphoneSmartphone.ReceberLigacao();
iphoneSmartphone.InstalarAplicativo("Whatsapp");