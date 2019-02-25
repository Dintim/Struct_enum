using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_structure
{
    public enum FamilyType { complete, incomplete}    
    public enum LearningType { fullTime, distance}
    public class Student
    {
        public string FullName { get; set; }
        public string Group { get; set; }
        public double AvgMark { get; set; }
        public double IncomePerFamMember { get; set; }
        public FamilyType FamilyType { get; set; }
        public Sex Sex { get; set; }
        public LearningType LearningType { get; set; }

        public Student() { }
        public Student(string fullName, Sex sex, string group, double avgMark, LearningType lt, double income, FamilyType family)
        {
            this.FullName = fullName;
            this.Sex = sex;
            this.Group = group;
            this.AvgMark = avgMark;
            this.LearningType = lt;
            this.IncomePerFamMember = income;
            this.FamilyType = family;
        }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", FullName, Group, AvgMark, LearningType, IncomePerFamMember, FamilyType);
        }
        public bool IsLessIncome()
        {
            return IncomePerFamMember < 2 * 50000;
        }
    }
    
}
