using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._12._12.gyakorlas
{
    internal class Dog
    {
        public string name { get; private set; }        // prop(erty)-vel hozom létre
        public int age { get; set; }
        public Dog(string name, int age)
        {
            if(name.Length < 1)
            {
                throw new Exception("Névtelen kutya");  //  ha nincs kitöltve a kutya neve, akkor hibát dob
            }
            this.name = name;
            this.age = age;
        }
        public void Bark()
        {
            MessageBox.Show($"Vau, vau, mondja {name}");
        }

    }
}
