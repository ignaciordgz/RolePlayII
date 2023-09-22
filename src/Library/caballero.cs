using System.Collections.Generic;

namespace Library;

public class Caballero
{
    public string Name { get; set; }
    public int Health { get; set;}

    public Inventario funda{ get; set; }

    public Caballero(string nombre)
    {
        this.Name = nombre;
        this.Health = 130;
        this.funda = new Inventario();
    }
}
