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
        T[] myArray;


        //Constructor 
        public CustomList()
        {
            count = 0;
            capacity = 4;
            myArray = new T[capacity];
            
        }
        public T this[int i]
        {
            get { return myArray[i]; }
            set { myArray[i] = value; }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
            
    
        //Member Methods
        public void Add(T item)
        {
            if (count == capacity)
            {
                T[] tempArray = new T[capacity *= 2];
               
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = myArray[i];
                }
                myArray = tempArray;
                myArray[count] = item;
            }
            else
            {
                myArray[count] = item;
            }
            


            //increment count
            count++;
            //item needs to land at next available index

            //check to make sure it persists

            //count == maxcapacity, we need to increase capacity and copy
        }
        public void Remove(T item)
        {

            if (true)
            {
                for ()
                {

                }
            }
            //decrement count

            //item needs to land at next available index

            //check to make sure it persists

            //count == maxcapacity, we need to decrease capacity and copy
        }

    }
}
