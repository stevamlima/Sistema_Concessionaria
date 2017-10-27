using System;
using Cliente;
using Carro;
using System.IO;
using NetOffice.ExcelApi;

namespace sistema_concessionaria
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastraCliente escolha = new CadastraCliente();
            escolha.end = new Endereco();
            DadosCarro dados = new DadosCarro();
            dados.addcar = new AdicionaisCarro();

            escolha.Opcao(); //chama a funcao de escolha(Opcao)
            string op = Console.ReadLine();
            
            switch(op)
            {
                case "1": //caso a variável 'op' for igual a UM, executa-se a funcao(PerguntaDados)
                Console.Clear();
                escolha.PerguntaDados();
                escolha.SalvaDadosCliente();
                break;

                case "2": //caso a variável 'op' for igual a DOIS, executa-se a funcao(CadastraCarro)
                Console.Clear();
                dados.CadastraCarro();
                dados.SalvaDadosCarro();
                break;
            }
        }
        
        
    }
}
