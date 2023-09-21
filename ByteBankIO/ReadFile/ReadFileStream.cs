using System.Text;

namespace ByteBankIO.ReadFile;

public class ReadFileStream
{
    public void ReadFile(string filePath)
    {
        var numeroDeBytesLidos = -1;

        using (var streamArquivo = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024]; // Buffer de 1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = streamArquivo.Read(buffer, 0, 1024);

                PrintBuffer(buffer, numeroDeBytesLidos);
            }


            streamArquivo.Close();
        }

        Console.ReadLine();
    }

    private void PrintBuffer(byte[] buffer, int bytesLidos)
    {
        UTF8Encoding utf8 = new UTF8Encoding();
        string text = utf8.GetString(buffer, 0, bytesLidos);


        Console.Write(text);
    }
}