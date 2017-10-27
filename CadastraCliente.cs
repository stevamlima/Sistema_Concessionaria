using System;
using Cliente;
using Carro;
using NetOffice.ExcelApi;

namespace Cliente
{
public class CadastraCliente
{
    public string nome { get; set; }
    public string idade { get; set; }
    public string email{ get; set; }
    public Endereco end { get; set; }

    public void Opcao()
    {
        Console.WriteLine("\n1 - Cadastrar Cliente");
        Console.WriteLine("2 - Cadastrar Carro");
        Console.WriteLine("3 - Comprar Carro");
        Console.WriteLine("4 - Listar carros não vendidos");
        Console.Write("\nEscolha uma das opções acima: ");
    }
    public void PerguntaDados()
    {
        Console.WriteLine("Cadastro de Cliente");
        Console.Write("\nNome: "); this.nome = Console.ReadLine();

        Console.Write("Idade: "); this.idade = Console.ReadLine();

        Console.Write("E-mail: "); this.email = Console.ReadLine();

        Console.Write("Logradouro: "); this.end.logradouro = Console.ReadLine();

        Console.Write("Número: "); this.end.num = Console.ReadLine();
        
        Console.Write("CEP: "); this.end.cep = Console.ReadLine();
    }
    public void SalvaDadosCliente()
    {
        Application ex = new Application();
        ex.Workbooks.Add();
        ex.Cells[1,1].Value = this.nome;
        ex.Cells[2,1].Value = this.idade;
        ex.Cells[3,1].Value = this.email;
        ex.Cells[4,1].Value = this.end.logradouro;
        ex.Cells[5,1].Value = this.end.num;
        ex.Cells[6,1].Value = this.end.cep;
        ex.ActiveWorkbook.SaveAs("CadastroDeCarros.xls");
        ex.Quit();
        ex.Dispose();
    }
}
}