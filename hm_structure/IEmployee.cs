using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_structure
{
    public enum Sex { female, male}
    public enum Position {director=1, accounter, salesManager, itSpecialist }
    public interface IEmployee
    {
        string Name { get; set; }
        string Surname { get; set; }
        Sex Sex { get; set; }
        Position Position { get; set; }
        DateTime HiredDate { get; set; }
        double Salary { get; set; }
    }
}
