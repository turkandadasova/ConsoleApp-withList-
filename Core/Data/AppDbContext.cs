using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Data
{
    public static class AppDbContext
    {
        static List<Room> rooms = new List<Room>();
       private static List<Hotel> hotel = new List<Hotel>();

        public static void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public static List<Room> FindAllRoom(bool IsAvialable)
        {
            return rooms.FindAll(x => x.IsAvialable == IsAvialable);
        }

        public static void MakeReservation(int? roomld,int customerscount)
        {

        }
    }
}
