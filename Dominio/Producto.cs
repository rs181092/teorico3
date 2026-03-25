using Dominio.Interfaces;

namespace Dominio;

public class Producto : IValidable
{
    private string _nombre;
    private double _precio;

    public Producto(string nombre, double precio)
    {
        _nombre = nombre;
        _precio = precio;
    }

    public bool Validar()
    {
        return !string.IsNullOrEmpty(_nombre) && _precio >= 0;
    }
}