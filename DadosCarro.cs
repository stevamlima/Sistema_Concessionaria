using System;
using Cliente;
using Carro;
using NetOffice.ExcelApi;

namespace Carro
{
public class DadosCarro
{
    public string marca { get; set; }
    public string modelo {get; set; }
    public string ano { get; set; }
    public AdicionaisCarro addcar {get; set; } 

    public void CadastraCarro()
    {
        Console.WriteLine("Cadastro de Carro");
        Console.Write("\nMarca: "); this.marca = Console.ReadLine();

        Console.Write("Modelo: "); this.modelo = Console.ReadLine();

        Console.Write("Ano: "); this.ano = Console.ReadLine();

        Console.Write("Tipo do vidro: "); this.addcar.vidro = Console.ReadLine();

        Console.Write("Motor: "); this.addcar.motor = Console.ReadLine();
        
        Console.Write("Direção: "); this.addcar.direcao = Console.ReadLine();
    }
}
}