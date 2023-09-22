using System.Collections.Generic;
using System.Data;

namespace Library;

public class Hechizos
{
    public string Name { get; set; }
    public int damage { get; set; }
    public Hechizos(string name, int damage)
    {
        this.Name = name;
        this.damage = damage;
    }
}