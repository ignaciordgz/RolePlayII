using System;
using System.Collections.Generic;
using System.Data;

namespace Library;

public class Elfo : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set;}

    public Inventario Bolsa { get; set; }

    public Elfo(string nombre)
    {
        this.Name = nombre;
        this.Health = 100;
        this.Bolsa = new Inventario();
    }
    public void PrintInfo()
    {
        
    }
}