using DesafioPOO.Models;
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO: Realizar os testes com as classes Nokia e Iphone
var nokia = new Nokia("12345678", "Expert", "1A2B3C4D5E6F", 8192);
ImprimeDadosEoUsoSmartPhone(nokia, "Nokia");
var iphone = new Iphone("87654321", "IPhone 16", "F6E5D4C3B21A", 16384);
ImprimeDadosEoUsoSmartPhone(iphone, "IPhone");
FinalizarPrograma();

static void ImprimeDadosEoUsoSmartPhone(Smartphone telefone, String nomeApp)
{
    ImprimeLinha();
    Console.WriteLine($"Dados do smartphone {nomeApp}:");
    Console.WriteLine($"Número  : {telefone.Numero}");
    Console.WriteLine($"Modelo  : {telefone.Modelo}");
    Console.WriteLine($"IMEI    : {telefone.IMEI}");
    Console.WriteLine($"Memória : {telefone.Memoria}");
    ImprimeLinha();
    telefone.InstalarAplicativo(nomeApp);
    ImprimeLinha();
    telefone.Ligar();
    ImprimeLinha();
    telefone.ReceberLigacao();
}

static void FinalizarPrograma()
{
    ImprimeLinha();
    var _finalizacaoPrograma = "Pressione uma tecla para finalizar o programa...";
    Console.WriteLine(_finalizacaoPrograma);
    Console.ReadKey();
}

static void ImprimeLinha()
{
    var newLine = new String('=', 60);
    Console.WriteLine(newLine);
}