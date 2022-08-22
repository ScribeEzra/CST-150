//Corrected by Christa Moncrief
//use for IC08
//Lydia's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                //naming rule violation
                //A.addElement(r.Next(4));
                //B.addElement(r.Next(12));
                A.AddElement(r.Next(4));
                B.AddElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.Union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

            //just added this to use as a breakpoint
            r.Next();

        }
    }
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        //naming rule violation
        //public bool addElement(int val)
        public bool AddElement(int val)
        {
            //it's safer to use brackets
            //naming rule violation
            //if (containsElement(val)) return false;
            if (ContainsElement(val))
            {
                return false;
            }
            else
            {
                elements.Add(val);
                return true;
            }
        }
        //naming rule violation
        //private bool containsElement(int val)
        private bool ContainsElement(int val)
        {
            //adding bool variable set to false
            bool containsElement = false;
            for (int i = 0; i < (elements.Count); i++)
            {
                if (val == elements[i])
                    //switch containsElement to true only if value is found
                    //return true;
                    containsElement =  true;
                //the else branch isn't necesary
                //else

                    //return false;
            }
            //would return false each time
            //switch to returning a bool variable
            //return false;
            return containsElement;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        //naming rules violation
        //public void clearSet()
        public void ClearSet()
        {
            elements.Clear();
        }

        //naming rule violation
        //public Set union(Set rhs)
        public Set Union(Set rhs)
        {
            //create a new set
            Set unionSet = new Set();

            //added another for loop to add elements from set a to new set first
            for (int i = 0; i < this.elements.Count; i++)
            {
                unionSet.AddElement(this.elements[i]);
            }

            //switch this to specifically rhs.elements.Count
            //for (int i = 0; i < elements.Count; i++)
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //naming rules violation
                //this.addElement(rhs.elements[i]);
                unionSet.AddElement(rhs.elements[i]);
            }
            //return rhs was returning one of the original sets
            //the union set needs to be returned instead
            //return rhs;
            return unionSet;
        }
    }
}


