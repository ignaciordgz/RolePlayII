using System.Collections.Generic;
using Library;
using NUnit.Framework;


namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void TestCalcularAtaque()
        {
            List<Item> items = new List<Item>
            {
                new Item("espada", 20, 3),
                new Item("arco", 15, 2)
            };
            Combate combate = new Combate();

            int ataqueTotal = combate.CalcularAtaqueTotal(items);

            Assert.AreEqual(35, ataqueTotal);
        //*Este caso de prueba comprueba que se calcule correctamente el ataque del personaje con sus items
        }

        [Test]
        public void TestCalcularDefensa()
        {
            List<Item> items = new List<Item>
            {
                new Item("escudo", 0, 25),
                new Item("armadura", 5, 15)
            };
            Combate combate = new Combate();

            int defensaTotal = combate.CalcularDefensaTotal(items);

            Assert.AreEqual(40, defensaTotal);
        //*Este caso de prueba comprueba que se calcule correctamente la defensa del personaje con sus items
        }
    
        [Test]
        public void TestAgregarItem()
        {
            Inventario inventario = new Inventario();
            Item espada = new Item("espada", 20, 3);

            inventario.AgregarItem(espada);

            List<Item> items = inventario.MostrarInventario();
            Assert.That(items, Contains.Item(espada));
        //*Comprueba que se agreguen los items correctamente.
        }
        [Test]
        public void TestRemoverItem()
        {

            Inventario inventario = new Inventario();
            Item espada = new Item("espada", 20, 3);
            inventario.AgregarItem(espada);

            inventario.RemoverItem(espada);

            List<Item> items = inventario.MostrarInventario();
            Assert.That(items, Does.Not.Contain(espada));
        //*Comprueba que se remuevan los items correctamente
        }
    }
}