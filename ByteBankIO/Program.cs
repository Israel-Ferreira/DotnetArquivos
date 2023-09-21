using ByteBankIO.ReadFile;

namespace ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        
        var readFileStream = new ReadFileStream();
        string enderecoArquivo = "contas.txt";
        
        readFileStream.ReadFile(enderecoArquivo);
    }
    
}