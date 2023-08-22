using System.Text;

namespace ExercLeituraArquivo;

class Program
{
    static void Main(string[] args)
    {
        string pathFile =  "arquivo.txt";
        
        using (var fs =  new FileStream(pathFile, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer =  new byte[1024];
            var encoding =  Encoding.ASCII;
            
            var bytesLidos = fs.Read(buffer, 0, 1024);
            var fileContent = encoding.GetString(buffer, 0, buffer.Length);
            
            Console.WriteLine(fileContent);
        }
    }
}