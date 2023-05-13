using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        public class GenArray<T>
        {
            public List<T> array=new List<T>();

            public void Adding(T item) { array.Add(item);}

            public void Clear() { array.Clear(); }

            public T GetValue(int index) { return array[index];}

            public void Print()
            {
                for(int i  = 0; i < array.Count; i++) { Console.WriteLine(array[i]);}
            }

            public void Remove(int index) { array.RemoveAt(index);}

        }
        static void Main(string[] args)
        {
            GenArray<int> IBob = new GenArray<int>();
            GenArray<string> SBob = new GenArray<string>();
            IBob.Adding(1);
            IBob.Adding(2);
            IBob.Adding(3);
            IBob.Remove(2);
            IBob.Print();
            SBob.Adding("a");
            SBob.Adding("b");
            SBob.Adding("c");
            SBob.Remove(2);
            SBob.Print();
        }
    }
}
