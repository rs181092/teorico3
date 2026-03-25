using Dominio;

namespace Consola;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Producto p1 = new Producto("Azucarlito", 100);
        Producto p2 = new Producto("Azucarlito", 200);
        Producto p3 = new Producto("Azucarlito", 300);

        try
        {
            p1.Validar();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        //Producto.Iva = 50;
        Producto.ModificarIva(50);
        
        Console.WriteLine();
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }
}