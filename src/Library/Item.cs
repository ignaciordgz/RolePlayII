using System.Collections.Generic;

namespace Library;

public class Item
{
    public string name { get; set; }
    public int ataque { get; set; }
    public int defensa { get; set; }
    public List<Hechizos> Hechizos { get; set; }

    public Item(string name, int ataque, int defensa)
    {
        this.name = name;
        this.ataque = ataque;
        this.defensa = defensa;
        this.Hechizos = null;
    }

// Creamos 2 constructores para que no de error a la hora de asignar el Libro de hechizos de la clase MAGO ya que contiene mas de un ataque
    public Item(string name, int ataque, List<Hechizos> hechizos)
    {
        this.name = name;
        this.ataque = ataque;
        this.Hechizos = hechizos;
        this.defensa = 0;
    }
}