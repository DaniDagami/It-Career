using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3 {
    public class Family {
        public Family() {
            People= new List<Person>();
        }
        public List<Person> People { get; set; }

        public void PrintAbove30() {
            foreach (Person person in People) {
                if (person.Age > 30) {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
