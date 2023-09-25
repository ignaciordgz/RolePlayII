using System.Collections.Generic;
using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballero Gervacio = new Caballero("Gervacio");
            Item Espada = new Item("Espada", 20, 3);
            Item Armadura = new Item("Armadura", 0, 30);
            
            Gervacio.funda.AgregarItem(Espada);
            Gervacio.funda.AgregarItem(Armadura);
            Combate CaballeroAD = new Combate();
            
            int AtaqueCaballero = CaballeroAD.CalcularAtaqueTotal(Gervacio.funda.ListaItems);
            int DefensaCaballero = CaballeroAD.CalcularDefensaTotal(Gervacio.funda.ListaItems);
            
            Console.WriteLine($"Nombre del Caballero : {Gervacio.Name}");
            Console.WriteLine($"Ataque Total : {AtaqueCaballero}");
            Console.WriteLine($"Defensa Total : {DefensaCaballero}");
            Console.WriteLine("------------------");
              

            Enano Thorin = new Enano("Thorin");
            Item hacha = new Item("hacha", 15, 2);
            Item escudo = new Item("escudo", 0, 25);

            Thorin.mochila.AgregarItem(hacha);
            Thorin.mochila.AgregarItem(escudo);

            Combate EnanoAD= new Combate();
            int AtaqueEnano = EnanoAD.CalcularAtaqueTotal(Thorin.mochila.ListaItems);
            int DefensaEnano = EnanoAD.CalcularDefensaTotal(Thorin.mochila.ListaItems);

            Console.WriteLine($"Nombre del Enano : {Thorin.Name}");
            Console.WriteLine($"Ataque Total : {AtaqueEnano}");
            Console.WriteLine($"Defensa Total : {DefensaEnano}");
            Console.WriteLine("------------------");      
    
    
            Elfo Lego = new Elfo("Lego");
            Item Arco = new Item("Arco", 25, 0);
            Item Traje = new Item("Traje", 0, 25);
            
            Lego.Bolsa.AgregarItem(Arco);
            Lego.Bolsa.AgregarItem(Traje);
            Combate ElfoAD = new Combate();
            
            int AtaqueElfo = ElfoAD.CalcularAtaqueTotal(Lego.Bolsa.ListaItems);
            int DefensaElfo = ElfoAD.CalcularDefensaTotal(Lego.Bolsa.ListaItems);
            
            Console.WriteLine($"Nombre del Elfo : {Lego.Name}");
            Console.WriteLine($"Ataque Total : {AtaqueElfo}");
            Console.WriteLine($"Defensa Total : {DefensaElfo}");
            Console.WriteLine("------------------");
    
             
            Mago Rasagast = new Mago("Rasagast");   
            Item BastonMagico = new Item("Baston Magico",25,2);  
            
            List<Hechizos> Hechizos = new List<Hechizos>{new Hechizos("Bola de fuego", 25),new Hechizos("Incinerar", 30),new Hechizos("Congelar", 5)};
            Rasagast.AgregarHechizos(Hechizos);
            
            Inventario SombreroMagico = new Inventario();
            Rasagast.SombreroMagico.AgregarItem(BastonMagico);
    
            int DañoAcumuladoHechizos = 0;
            foreach(var i in Hechizos)
            {
                DañoAcumuladoHechizos = DañoAcumuladoHechizos + i.damage;
            }
            int DañoTotalMago = DañoAcumuladoHechizos + BastonMagico.ataque;

            Item LibroHechizos = new Item("LibroHechizos",DañoAcumuladoHechizos,Hechizos);
            SombreroMagico.AgregarItem(LibroHechizos);

            Combate MagoAD = new Combate ();
            int DefensaMago = MagoAD.CalcularDefensaTotal(Rasagast.SombreroMagico.ListaItems);
            int AtaqueMago = MagoAD.CalcularAtaqueTotal(Rasagast.SombreroMagico.ListaItems);

            Console.WriteLine($"Nombre del Mago : {Rasagast.Name}");
            Console.WriteLine($"Ataque Total : {DañoTotalMago}");
            Console.WriteLine($"Defensa Total : {DefensaMago}");
            Console.WriteLine("------------------");

            Console.WriteLine(CaballeroAD.PeleaCaballeroEnano(Gervacio,Thorin));
            Console.WriteLine(MagoAD.PeleaMagoElfo(Rasagast,Lego));
            Console.WriteLine("------------------");
            Console.WriteLine(Combate.Curar(Rasagast,Lego,Thorin,Gervacio));

            ICharacter Gervacio2 = new Caballero("GERVACIO2");
            
            Item Espada1 = new Item("Espada", 20, 3);
            Item Armadura1 = new Item("Armadura", 0, 30);
            
            Gervacio2.funda.AgregarItem(Espada1);
            
            Gervacio2.PrintInfo();
        }
        }
    }
