//Corrected by <Brett>
//use for IC08
//Lydia's code

/*Unneccessary directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
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
                A.addElement(r.Next(4)); 
                B.addElement(r.Next(12));
            }
            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

            //Moved below line up to be read correctly.
            Console.WriteLine("After union operation");
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            //Console.WriteLine("After union operation"); 

            //I don't see any reason for the below lines to be repeated.
            //Console.WriteLine("A: " + A); 
            //Console.WriteLine("B: " + B);
        }
    }
}
//Set Describe several debugging techniques and scenarios for their use.
//Lydia's code - find the errors!

//Unneccesary repeat of namespace
//namespace CST117_IC08_console
//{
    class Set
    {
        private List<int> elements;
        public Set()
        {
            //missing > after int
            //  elements = new List<int();
          elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) 
                return false;
            else {
                elements.Add(val); 
                return true; 
            }
        }
        private bool containsElement(int val){
            for (int i = 0; i < elements.Count; i++) { 
                if (val == elements[i]) 
                    return true;
                //i was unreachable code with below else statement.
                //else return false; 
            } 
            return false;
        }
        public override string ToString() { 
            string str = ""; 
            foreach (int i in elements) { 
                str += i + " ";
            } 
            return str;
        }
        public void clearSet() { 
            elements.Clear(); 
        }

        //Set union rewrote below to use new set and properly compare sets
        /*Not working code.
        public Set union(Set rhs) {
            for (int i = 0; i < rhs.elements.Count; i++) {
                this.addElement(rhs.elements[i]);
            } return rhs;
        }
        */
        
        //Working code
        public Set union(Set rhs)
        {
            Set C = new Set();
            //loop passes first set and adds unique elements
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                C.addElement(rhs.elements[i]);
            }
            //passes second set and adds unique elements
            for (int i = 0; i < this.elements.Count; i++)
            {
                C.addElement(this.elements[i]);
            }
            return C;
        }
    }
//}