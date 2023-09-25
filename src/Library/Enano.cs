using System;
using System.Collections.Generic;
using System.Data;

namespace Library;

public class Enano : ICharacter
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
    public void PrintInfo()
    {
        
    }
}