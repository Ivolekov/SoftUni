using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    using System.Collections;

    public class GenericList<T> : IEnumerable
        where T:IComparable<T>
    {
        private const int Defaultcapacity = 16;

        private T[] elements;

        private int count = 0;

        public GenericList(int capacity = Defaultcapacity)
        {
            this.elements = new T[capacity];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T element)
        {
            if (this.count == this.elements.Length)
            {
                this.Rezise();
            }
            this.elements[this.count] = element;
            this.count++;
        }

        public void Remove(int index)
        {
            for (int i = index; i < this.count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.count--;
        }

        public void Insert(T element, int index)
        {
            if (this.count == this.elements.Length)
            {
                this.Rezise();
            }

            for (int i = this.count; i >= index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            this.count++;
        }

        public void Clear()
        {
            for (int i = 0; i < this.count; i++)
            {
                this.elements[i] = default(T);
            }
            this.count = 0;
        }

        public int FindIndex(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.Equals(element))
                {
                    return i;
                }
                
            }
            return -1;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.Equals(element))
                {
                    return true;
                }

            }
            return false;
        }

        public T Min()
        {
            T min = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.CompareTo(min) < 0)
                {
                    min = currentElement;
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.CompareTo(max) > 0)
                {
                    max = currentElement;
                }
            }
            return max;
        }

        public override string ToString()
        {
            var resultElement = this.elements.Take(this.count);
            return string.Join(", ", resultElement);
        }

        private void Rezise()
        {
            T[] newElement = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newElement[i] = this.elements[i];
            }
            this.elements = newElement;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
