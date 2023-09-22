using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library
{
    public class Combate
    {
        public int CalcularAtaqueTotal(List<Item> items)
        {
            int ataqueTotal = 0;
            foreach (Item item in items)
            {
                ataqueTotal += item.ataque;
            }
            return ataqueTotal;
        }

        public int CalcularDefensaTotal(List<Item> items)
        {
            int defensaTotal = 0;
            foreach (Item item in items)
            {
                defensaTotal += item.defensa;
            }
            return defensaTotal;
        }
        public string PeleaCaballeroEnano(Caballero caballero, Enano enano)
        {
            int ataqueTotalCaballero = 0;
            
            foreach(var item in caballero.funda.ListaItems)
            {
                ataqueTotalCaballero = CalcularAtaqueTotal(caballero.funda.ListaItems);
                enano.Health = enano.Health - ataqueTotalCaballero;
            }
            return $"Vida restante del Enano luego de la pelea con Caballero : {enano.Health}";
        }
        public string PeleaMagoElfo(Mago mago, Elfo elfo)
        {
            int ataqueTotalMagoHechizos = 0;
            int ataqueTotalMago = 0;
            int ataqueMago = 0;
            
            List<Hechizos> hechizos1 = new List<Hechizos>{new Hechizos("Bola de fuego", 25),new Hechizos("Incinerar", 30),new Hechizos("Congelar", 5)};
            foreach(var item in hechizos1)
            {
                ataqueTotalMagoHechizos = ataqueTotalMagoHechizos + item.damage;
            }

            foreach(var item in mago.SombreroMagico.ListaItems)
            {
                ataqueMago = ataqueMago + item.ataque;
            }
            ataqueTotalMago = ataqueTotalMagoHechizos + ataqueMago;
            elfo.Health = elfo.Health - ataqueTotalMago;
            
            return $"Vida restante del Elfo luego de la pelea con Mago : {elfo.Health}";
        }
        public static string Curar(Mago mago, Elfo elfo, Enano enano, Caballero caballero)
        {
            if (mago.Health < 80)
            {
                mago.Health = 80;
            }
            if (elfo.Health < 100)
            {
                elfo.Health = 100;
            }
            if (enano.Health < 150)
            {
                enano.Health = 150;
            }
            if (caballero.Health < 130)
            {
                caballero.Health = 130;
            }
            return $"Curacion Finalizada, : {caballero.Health}, {enano.Health}, {mago.Health}, {elfo.Health}";
        }
    }
}