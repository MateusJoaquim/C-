using System.Globalization;
using System.Collections;

internal class NewBaseType
{
    private static void Main(string[] args)
    {
        Console.Clear();

        var arr = new int[3];


        try
        {
            // for (var index = 0; index < 10; index++)
            // {
            //     //IndexOutOfRangeException
            //     Console.WriteLine(arr[index]);
            // }
            Cadastrar("");
        }
        catch (MinhaException ex)
        {

            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.QuandoAconteceu);
            Console.WriteLine("exceçã customizada");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ops, algo deu errado");

        }
        finally
        {

            Console.WriteLine("Cheugou ao fim!");
        }
    }

    private static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            throw new MinhaException(DateTime.Now);
    }

    internal class Program : NewBaseType
    {
        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {

                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}