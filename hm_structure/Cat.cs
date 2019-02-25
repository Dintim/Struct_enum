using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_structure
{
    public enum Food {milk=1, mouse, fish, meat}
    public class Cat
    {
        public string Name { get; set; }
        public int SatietyLevel { get; private set; }
        public Cat()
        {
            Name = "Мурка";
        }
        public void EatSmth(Food food)
        {
            SatietyLevel = (int)food;
        }

    }
}
