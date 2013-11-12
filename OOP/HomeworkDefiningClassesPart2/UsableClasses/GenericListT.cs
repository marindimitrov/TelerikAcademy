namespace UsableClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
    //Keep the elements of the list in an array with fixed capacity which is given as parameter in 
    //the class constructor. Implement methods for adding element, accessing element by index, 
    //removing element by index, inserting element at given position, clearing the list, finding 
    //element by its value and ToString(). Check all input parameters to avoid accessing elements 
    //at invalid positions.

    public class GenericList<T>
    {
        T[] elements;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        public void AddElement(int position, T element)
        {
            elements[position] = element;
        }

        public T AccessElementByIndex(int index)
        {
            return elements[index];
        }

        public void RemoveElementByIndex(int index)
        {
            List<T> temp = new List<T>();

            foreach (var item in elements)
            {
                temp.Add(item);
            }
            temp.RemoveAt(index);

            if (temp.Count < elements.Length)
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = default(T);
                }
                for (int i = 0; i < temp.Count; i++)
                {
                    elements[i] = temp[i];
                }
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = temp[i];
                }
            }

        }

        public void InsertElementAtGivenPosition(int index, T element)
        {
            List<T> temp = new List<T>();
            foreach (var item in elements)
            {
                temp.Add(item);
            }
            temp.Insert(index, element);

        }
    }
}