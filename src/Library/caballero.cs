using System;
using System.Collections.Generic;
using System.Data;

namespace Library;

public class Caballero : ICharacter
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
    public void PrintInfo()
    {
        Console.WriteLine($"Nombre del Caballero : {this.Name}");
        Console.WriteLine($"Vida : {this.Health}");
        funda.PrintInfo();
    }
}
