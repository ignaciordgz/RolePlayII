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
            
            Gervacio.PrintInfo();
            ((Caballero)Gervacio).funda.AgregarItem(Armadura);
            Combate CaballeroAD = new Combate();
            
            int AtaqueCaballero = CaballeroAD.CalcularAtaqueTotal(((Caballero)Gervacio).funda.ListaItems);
            int DefensaCaballero = CaballeroAD.CalcularDefensaTotal(((Caballero)Gervacio).funda.ListaItems);
            
            Console.WriteLine($"Nombre del Caballero : {((Caballero)Gervacio).Name}");
            Console.WriteLine($"Ataque Total : {AtaqueCaballero}");
            Console.WriteLine($"Defensa Total : {DefensaCaballero}");
            Console.WriteLine("------------------");
            {
            ICharacter Thorin = new Enano("Thorin");
            Item hacha = new Item("hacha", 15, 2);
            Item escudo = new Item("escudo", 0, 25);

            ((Enano)Thorin).mochila.AgregarItem(hacha);
            ((Enano)Thorin).mochila.AgregarItem(escudo);

            Combate EnanoAD= new Combate();
            int AtaqueEnano = EnanoAD.CalcularAtaqueTotal(((Enano)Thorin).mochila.ListaItems);
            int DefensaEnano = EnanoAD.CalcularDefensaTotal(((Enano)Thorin).mochila.ListaItems);

            Console.WriteLine($"Nombre del Enano : {((Enano)Thorin).Name}");
            Console.WriteLine($"Ataque Total : {AtaqueEnano}");
            Console.WriteLine($"Defensa Total : {DefensaEnano}");
            Console.WriteLine("------------------");      
    
    
            ICharacter Lego = new Elfo("Lego");
            Item Arco = new Item("Arco", 25, 0);
            Item Traje = new Item("Traje", 0, 25);
            
            ((Elfo)Lego).Bolsa.AgregarItem(Arco);
            ((Elfo)Lego).Bolsa.AgregarItem(Traje);
            Combate ElfoAD = new Combate();
            
            int AtaqueElfo = ElfoAD.CalcularAtaqueTotal(((Elfo)Lego).Bolsa.ListaItems);
            int DefensaElfo = ElfoAD.CalcularDefensaTotal(((Elfo)Lego).Bolsa.ListaItems);
            
            Console.WriteLine($"Nombre del Elfo : {((Elfo)Lego).Name}");
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
}