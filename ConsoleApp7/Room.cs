using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Room
    {
        public static int counter;
        private static int _Id = ++counter;
        public string Name;
        public int Price;
        public int PersonCapacity;
        private bool _IsAvialable;

        public int Id
        {
            get { return _Id; }
            set { value = _Id; }
        }
        public Room(string name, int price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            _IsAvialable = true;
        }
        public bool IsAvialable
        {
            get { return _IsAvialable; }
            set
            {
                if (value == true)
                {
                    Console.WriteLine("rezervasiya olunub");
                    return;
                }
                Console.WriteLine("rezervasiya olunmayib");

            }
        }
        public string ShowInfo()
        {
            return $"Id:{Id} Name:{Name} Price:{Price} PersonCapacity:{PersonCapacity} Is it Avialable:{IsAvialable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
