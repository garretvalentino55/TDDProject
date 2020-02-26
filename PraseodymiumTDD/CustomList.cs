using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraseodymiumTDD
{
    public class CustomList<T>
    {

        //Member Variables 
        int count;
        int capacity;
        T[] items;
        


        //Constructor 
        public CustomList()
        {
            count = 0;
            capacity = 0;
            items = new T[capacity];
            
        }
        public int Count { get; }
        public int Capacity { get; set; }

        //Member Methods
        public void Add(T item)
        {
            if (count == capacity)
            {

                items[count] = item;
                items = new T[4];
                for (int i = 0; i < count; i++)
                {

                }

            }



            //increment count

            //item needs to land at next available index

            //check to make sure it persists

            //count == maxcapacity, we need to increase capacity and copy
        }
        public void Remove(T item)
        {
            //decrement count

            //item needs to land at next available index

            //check to make sure it persists

            //count == maxcapacity, we need to decrease capacity and copy
        }

    }
}
