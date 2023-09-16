using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2 {
    public class Family {
        public Family(string familyName) {
            FamilyName = familyName;
            People = new List<Person>();
        }

        public string FamilyName { get; set; }
        public List<Person> People { get; set; }

        public void Print() {
            foreach (Person person in People) {
                Console.WriteLine(person);
            }
        }
    }
}
