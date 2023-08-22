using System.Text;
using ByteBankIO;

namespace ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        
        var numeroDeBytesLidos = -1;
        
        string enderecoArquivo = "contas.txt";
        
        var streamArquivo =  new FileStream(enderecoArquivo, FileMode.Open,FileAccess.Read);
        
        byte[] buffer = new byte[1024]; // Buffer de 1KB
        
        while(numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = streamArquivo.Read(buffer, 0, 1024);
            PrintBuffer(buffer);
        }
        
        Console.ReadLine();
    }
    
    
    static void PrintBuffer(byte[] buffer)
    {
        UTF8Encoding utf8 =  new UTF8Encoding();
        string text  =  utf8.GetString(buffer);
        
        Console.Write(text);
    }
}