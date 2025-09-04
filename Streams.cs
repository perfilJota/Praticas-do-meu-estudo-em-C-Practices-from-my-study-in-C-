using System.Dynamic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace streams
{

    public class Streams
    {
        public List<string> RotasUsadas { get; set; } = null!;
        public List<StreamReader> StreamReaders { get; set; } = new List<StreamReader>();
        public void CreatStreams(int Quantidade)
        {
            for(int i = 0; i < Quantidade; i++)
            {
                System.Console.WriteLine("Digite o caminho do arquivo:");
                string rota = Console.ReadLine()!;
                      StreamReader reader = File.OpenText(rota);
                      StreamReaders.Add(reader);
                      RotasUsadas.Add(rota);
            }            
             foreach(var  item in StreamReaders)
                    {
                        while(!item.EndOfStream)
                        {
                           System.Console.WriteLine(item.ReadLine());
                        }
                    }
                     foreach(var Abertos in StreamReaders)
                        {
                            Abertos.Close();
                        }
        }
    }

}
