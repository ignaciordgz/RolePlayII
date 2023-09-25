using System;
using System.Collections.Generic;
using System.Data;

namespace Library;

public class Mago : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Hechizos> Hechizos { get; } = new List<Hechizos>();
    public Inventario SombreroMagico { get; set; }
    public Mago(string name)
    {
        this.Name = name;
        this.Health = 80;
        this.SombreroMagico = new Inventario();
    } 
    public void AgregarHechizos(List<Hechizos> hechizos)
    {
        Hechizos.AddRange(hechizos);
    }
   public void PrintInfo()
    {
        Console.WriteLine($"Nombre del Mago : {this.Name}");
        Console.WriteLine($"Vida : {this.Health}");
        SombreroMagico.PrintInfo();
    }
}