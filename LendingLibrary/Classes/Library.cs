using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Library<T> : IEnumerable
    {
        T[] books = new T[1];
        int amount = 0;

        public void Add(T book)
        {
            if (amount == books.Length)
            {
                Array.Resize(ref books, (books.Length + 1));
            }
            books[amount] = book;
            amount++;
        }

        public void Remove(T book)
        {
            T[] temp = new T[amount];
            int counter = 0;

            foreach (T b in books)
            {
                if (!b.Equals(book))
                {
                    temp[counter] = b;
                    counter++;
                }
            }
            books = temp;

            if (counter != amount)
            {
                Array.Resize(ref books, (books.Length - (amount - counter)));
                amount -= (amount - counter);
            }
        }

        public int Count()
        {
            return amount;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < amount; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
