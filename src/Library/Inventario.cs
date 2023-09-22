using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Library;

public class Inventario
{
    public List<Item> ListaItems { get; set; }
    public Inventario()
    {
        this.ListaItems = new List<Item>();
    }

    public void AgregarItem(Item item)
    {

        ListaItems.Add(item);
    }

    public void RemoverItem(Item item)
    {
        ListaItems.Remove(item);
    }

    public List<Item> MostrarInventario()
    {
        return ListaItems;
    }
}