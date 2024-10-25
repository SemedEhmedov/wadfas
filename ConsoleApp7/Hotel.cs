using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Hotel
    {
        public int Id;
        public string Name;
        private Room[] Rooms;

        public Hotel()
        {
            Rooms = new Room[0];
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms,Rooms.Length+1);
            Rooms[^1] = room;
        }
        public string FindAllRoom()
        {
            foreach(Room room in Rooms)
            {
                if (room.IsAvialable)
                {
                    return room.Name;
                }
            }
            return null; 
        }
        public string FindAllRoom(int customers)
        {
            foreach(Room room in Rooms)
            {
                if (room.PersonCapacity > customers)
                {
                    return room.Name;
                }
            }
            return null ;
        }
        public string  FindAllRoom(int min,int max)
        {
            foreach (Room room in Rooms)
            {
                if (room.Price > min && room.Price < max)
                {
                    return room.Name;
                }
            }
            return null;
        }
        public void MakeReservation(int? roomid , int? numbersofcustomers)
        {
            if (roomid == null) 
                throw new NullReferenceException("NULLLLLL");
            foreach(Room room in Rooms)
            {
                if(room.Id != roomid)
                {
                    Console.WriteLine("bele id li otaq yoxdur");
                }
                if((room.PersonCapacity < numbersofcustomers))
                {
                    Console.WriteLine("lazimli qeder yer yoxdur");
                }

            }
        }


    }
}
