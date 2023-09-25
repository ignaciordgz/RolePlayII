using System.Collections.Generic;
using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacter Gervacio = new Caballero("Gervacio");
            
            Item Espada = new Item("Espada", 20, 3);
            Item Armadura = new Item("Armadura", 0, 30);
            
            ((Caballero)Gervacio).funda.AgregarItem(Espada);
            ((Caballero)Gervacio).funda.AgregarItem(Armadura);
            
            Combate CaballeroAD = new Combate();
            int AtaqueCaballero = CaballeroAD.CalcularAtaqueTotal(((Caballero)Gervacio).funda.ListaItems);
            int DefensaCaballero = CaballeroAD.CalcularDefensaTotal(((Caballero)Gervacio).funda.ListaItems);
            
            Gervacio.PrintInfo();
            Console.WriteLine($"Ataque total del Caballero : {AtaqueCaballero}");
            Console.WriteLine($"Defensa total del Caballero : {DefensaCaballero}");
            Console.WriteLine("------------------");
            
            ICharacter Thorin = new Enano("Thorin");

            Item Hacha = new Item("Hacha", 15, 2);
            Item Escudo = new Item("Escudo", 0, 25);

            ((Enano)Thorin).mochila.AgregarItem(Hacha);
            ((Enano)Thorin).mochila.AgregarItem(Escudo);

            Combate EnanoAD = new Combate();
            int AtaqueEnano = EnanoAD.CalcularAtaqueTotal(((Enano)Thorin).mochila.ListaItems);
            int DefensaEnano = EnanoAD.CalcularDefensaTotal(((Enano)Thorin).mochila.ListaItems);

            Thorin.PrintInfo();
            Console.WriteLine($"Ataque total del Enano : {AtaqueEnano}");
            Console.WriteLine($"Defensa total del Enanoo : {DefensaEnano}");
            Console.WriteLine("------------------");      
    
    
            ICharacter Lego = new Elfo("Lego");

            Item Arco = new Item("Arco", 25, 0);
            Item Traje = new Item("Traje", 0, 25);
            
            ((Elfo)Lego).Bolsa.AgregarItem(Arco);
            ((Elfo)Lego).Bolsa.AgregarItem(Traje);

            Combate ElfoAD = new Combate();
            int AtaqueElfo = ElfoAD.CalcularAtaqueTotal(((Elfo)Lego).Bolsa.ListaItems);
            int DefensaElfo = ElfoAD.CalcularDefensaTotal(((Elfo)Lego).Bolsa.ListaItems);
            
            Lego.PrintInfo();
            Console.WriteLine($"Ataque Total : {AtaqueElfo}");
            Console.WriteLine($"Defensa Total : {DefensaElfo}");
            Console.WriteLine("------------------");
    
             
            ICharacter Rasagast = new Mago("Rasagast"); 
            
            Item BastonMagico = new Item("Baston Magico",25,2);  
            
            List<Hechizos> Hechizos = new List<Hechizos>{new Hechizos("Bola de fuego", 25),new Hechizos("Incinerar", 30),new Hechizos("Congelar", 5)};
            ((Mago)Rasagast).AgregarHechizos(Hechizos);
            
            Inventario SombreroMagico = new Inventario();
            ((Mago)Rasagast).SombreroMagico.AgregarItem(BastonMagico);
    
            int DañoAcumuladoHechizos = 0;
            foreach(var i in Hechizos)
            {
                DañoAcumuladoHechizos = DañoAcumuladoHechizos + i.damage;
            }
            int DañoTotalMago = DañoAcumuladoHechizos + BastonMagico.ataque;

            Item LibroHechizos = new Item("LibroHechizos",DañoAcumuladoHechizos,Hechizos);
            SombreroMagico.AgregarItem(LibroHechizos);

            Combate MagoAD = new Combate ();
            int DefensaMago = MagoAD.CalcularDefensaTotal(((Mago)Rasagast).SombreroMagico.ListaItems);
            int AtaqueMago = MagoAD.CalcularAtaqueTotal(((Mago)Rasagast).SombreroMagico.ListaItems);

            Rasagast.PrintInfo();
            Console.WriteLine($"Nombre del Mago : {((Mago)Rasagast).Name}");
            Console.WriteLine($"Ataque Total : {DañoTotalMago}");
            Console.WriteLine($"Defensa Total : {DefensaMago}");
            Console.WriteLine("------------------");

            Console.WriteLine(CaballeroAD.PeleaCaballeroEnano((Caballero)Gervacio,(Enano)Thorin));
            Console.WriteLine(MagoAD.PeleaMagoElfo((Mago)Rasagast,(Elfo)Lego));
            Console.WriteLine("------------------");
            Console.WriteLine(Combate.Curar((Mago)Rasagast,(Elfo)Lego,(Enano)Thorin,(Caballero)Gervacio));
        }
    }
} 