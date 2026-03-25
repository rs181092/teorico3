using Dominio.Interfaces;

namespace Dominio;

public class Producto : IValidable
{
    private string _nombre;
    private double _precio;
    private static double _iva = 22;

    public Producto(string nombre, double precio)
    {
        _nombre = nombre;
        _precio = precio;
    }
    
    //Propertie
    public static double Iva
    {
        get { return _iva;} 
        set  { _iva = value;}
    }

    public void Validar()
    {
        //return !string.IsNullOrEmpty(_nombre) && _precio >= 0;
        if (string.IsNullOrWhiteSpace(_nombre)) throw new Exception("El nombre no puede estar vacio.");
        if (_precio < 0) throw new Exception("El precio no puede ser menor de 0");

    }

    public double PrecioIvaIncluido()
    {
        return _precio + _precio * _iva / 100;
    }
    
    //ToString
    public override string ToString()
    {
        return $"{_nombre} - {_precio} - IVA: {_iva} - ${PrecioIvaIncluido()}";
    }
    
    //Metodo statico
    public static void ModificarIva(double nuevoIVA)
    {
        if(nuevoIVA <= 0) throw new Exception("El Iva no  puede ser menor de 0");
        _iva = nuevoIVA;
    }
}