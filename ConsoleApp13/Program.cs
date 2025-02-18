using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
  
        internal class Program
        {
            public class Item
            {
                public string Name { get; set; }
                public double Volume { get; set; }

                public Item(string name, double volume)
                {
                    Name = name;
                    Volume = volume;
                }
            }
            public class Backpack
            {
                public string Color { get; set; }
                public string Brand { get; set; }
                public string Fabric { get; set; }
                public double Weight { get; set; }
                public double Volume { get; set; }
                public double CurrentVolume { get; private set; }
                public List<Item> Contents { get; set; }
                public event EventHandler<Item> ItemAdded;
                public Backpack(string color, string brand, string fabric, double weight, double volume)
                {
                    Color = color;
                    Brand = brand;
                    Fabric = fabric;
                    Weight = weight;
                    Volume = volume;
                    CurrentVolume = 0;
                    Contents = new List<Item>();
                }
                public void AddItem(Item item)
                {
                    if (CurrentVolume + item.Volume > Volume)
                    {
                        throw new InvalidOperationException("Не вистачає місця в рюкзаку для цього предмета!");
                    }

                    Contents.Add(item);
                    CurrentVolume += item.Volume;
                    ItemAdded?.Invoke(this, item);
                }
                public void SetBackpackDetails(string color, string brand, string fabric, double weight, double volume)
                {
                    Color = color;
                    Brand = brand;
                    Fabric = fabric;
                    Weight = weight;
                    Volume = volume;
                    CurrentVolume = 0;
                }
            }

            static void Main()
            {

                Backpack myBackpack = new Backpack("Червоний", "Nike", "Нейлон", 1.5, 20.0);
                myBackpack.ItemAdded += delegate (object sender, Item e)
                {
                    Console.WriteLine($"Предмет '{e.Name}' додано до рюкзака.");
                };
                Item laptop = new Item("Ноутбук", 5.0);
                Item bottle = new Item("Пляшка", 1.5);
                Item book = new Item("Книга", 2.0);

                try
                {

                    myBackpack.AddItem(laptop);
                    myBackpack.AddItem(bottle);
                    myBackpack.AddItem(book);
                    Item largeItem = new Item("Великий предмет", 15.0);
                    myBackpack.AddItem(largeItem);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }





    