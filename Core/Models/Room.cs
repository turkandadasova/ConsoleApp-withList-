using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Models
{
    public class Room
    {
        
        public int Id { get; }
        private static int _id;
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvialable;

        public Room(string name, int price, int personCapacity)
        {
            ++_id;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }

        public Room()
        {
            
        }
    }
}
