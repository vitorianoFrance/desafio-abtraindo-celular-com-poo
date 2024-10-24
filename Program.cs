using DesafioPOO.Models;

// Realizando testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("73988888888", "Nokia 3310", "123456789012345", 64);

n1.InstalarAplicativo("LinkedIn");
n1.ReceberLigacao();

Iphone i1 = new Iphone("73999999999", "Iphone 16", "987654321054321", 128);

i1.InstalarAplicativo("Icloud");
i1.Ligar();