using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
namespace usuarios
{

    public class TabelaUsuarios
    {
        
        public string RotaTabelaDeUsuarios { get; set; } = @"C:\Users\jotadev\Documents\Teste de arquivos com c#\Tabelas\TabelaUsuarios.csv";
        public string[] TabelaConfigurada { get; set; } = null!;
        public void AddNewUsuario()
        { 
    using(StreamWriter writer = File.AppendText(RotaTabelaDeUsuarios))
        {         
            System.Console.WriteLine("Quantos usuarios deseja Adicionar?");
            int Resposta = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Digite respectivamente: Nome,ID,0");
            for(int i = 0; i < Resposta; i++)
            {  string Usuario = Console.ReadLine()!;
               writer.WriteLine(Usuario);
            }
        }
            
        }
        public void GetUsuarios()
        {
            using(StreamReader Leitor = File.OpenText(RotaTabelaDeUsuarios))
            {
                while(!Leitor.EndOfStream)
                {
                    var UsuariosSepadosPorLinha = Leitor.ReadLine();
                    
                    var SeparandoDadosDoUsuario = UsuariosSepadosPorLinha!.Split(",");
                    System.Console.WriteLine($"Nome:  {SeparandoDadosDoUsuario[0]}  ID:  {SeparandoDadosDoUsuario[1]}  Tempo Logado:  {SeparandoDadosDoUsuario[2]}");
                }

            }
            
        }
    }

}