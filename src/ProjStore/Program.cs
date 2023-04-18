using System.ComponentModel;
using System.Net.Sockets;
using Controllers;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Projeto LOJA");


        var data = new Store()
        {
            Description = "Teste",
            Address = "Rua do além",
        };

        string returnInformation = (new StoreController().Insert(data) ? "Inserido" : "Erro");
        Console.WriteLine(returnInformation);


        new StoreController().GetAll().ForEach(x => Console.WriteLine(x));

    }
}