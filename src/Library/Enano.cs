using System.Collections.Generic;

namespace Library;

public class Enano
{
    public string Name { get; set; }
    public int Health { get; set;}

    public Inventario mochila { get; set; }

    public Enano(string nombre)
    {
        this.Name = nombre;
        this.Health = 150;
        this.mochila = new Inventario();
    }
}