﻿using System;
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
        


        //Member Methods
        public void Add(T item)
        {

            items[count] = item;
            items = new T[4];
            bool checkIfFull =           




           
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
