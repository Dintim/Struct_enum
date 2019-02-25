using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeesTasks(5);

            //StudentTasks(2);

            CatTask(Food.mouse);
            
        }

        /// <summary>
        /// Задание №1. Создать массив сотрудников...
        /// </summary>
        /// <param name="task"></param>
        public static void EmployeesTasks (int task)
        {
            Employee e1 = new Employee("Din", "Muk", Sex.female, Position.itSpecialist, new DateTime(2018, 5, 22), 350500.5);
            Employee e2 = new Employee("Tim", "Kadyr", Sex.male, Position.director, new DateTime(2018, 6, 18), 400500.5);
            Employee e3 = new Employee("Ivan", "Ivan", Sex.male, Position.salesManager, new DateTime(2018, 4, 20), 250500.5);
            Employee e4 = new Employee("Madina", "Maulzharif", Sex.female, Position.itSpecialist, new DateTime(2018, 5, 24), 350500.5);
            Employee e5 = new Employee("Zhanar", "Sadyk", Sex.female, Position.accounter, new DateTime(2018, 4, 22), 350500.5);

            Employees emp = new Employees();
            emp.AddEmployee(e1);
            emp.AddEmployee(e2);
            emp.AddEmployee(e3);
            emp.AddEmployee(e4);
            emp.AddEmployee(e5);

            if (task == 1)
                //a.	вывести полную информацию обо всех сотрудниках; 
                emp.PrintAllEmployees();
            else if (task == 2)
            {
                //b.	вывести полную информацию о сотрудниках, выбранной должности
                Console.WriteLine("выберите должность (1-director, 2-accounter, 3-salesManager, 4-itSpecialist): ");
                int x = Int32.Parse(Console.ReadLine());
                if (x == 1)
                    emp.PrintEmployeesByPosition(Position.director);
                else if (x == 2)
                    emp.PrintEmployeesByPosition(Position.accounter);
                else if (x == 3)
                    emp.PrintEmployeesByPosition(Position.salesManager);
                else if (x == 4)
                    emp.PrintEmployeesByPosition(Position.itSpecialist);
            }
            else if (task == 3)
                //c.	найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, 
                //вывести на экран полную информацию о таких менеджерах отсортированной по их фамилии.
                emp.PrintEmployeesBySalary();
            else if (task == 4)
            {
                //d.	распечатать информацию обо всех сотрудниках, принятых на работу позже определенной даты (дата передается пользователем), 
                //отсортированную в алфавитном порядке по фамилии сотрудника.
                Console.Write("введите день: ");
                int d = Int32.Parse(Console.ReadLine());
                Console.Write("введите месяц: ");
                int m = Int32.Parse(Console.ReadLine());
                Console.Write("введите год: ");
                int y = Int32.Parse(Console.ReadLine());
                DateTime date = new DateTime(y, m, d);
                emp.PrintEmployeesByHiredDate(date);
            }
            else if (task == 5)
            {
                //e.	Вывести информацию о всех мужчинах, женщинах в зависимости от того что передаст пользователь. 
                //Предусмотреть случай, когда, пользователь не выбирает конкретный пол, т.е. просто хочет получить информацию о всех.
                Console.Write("выберите пол (0-муж, 1-жен, 2-никакой): ");
                int s = Int32.Parse(Console.ReadLine());
                if (s==0)
                    emp.PrintEmployeesBySex(Sex.male);
                else if (s==1)
                    emp.PrintEmployeesBySex(Sex.female);
                else if (s==2)
                    emp.PrintEmployeesBySex();
            }

        }

        /// <summary>
        /// Задание №2 - Для получения места в общежитии формируется список студентов...
        /// </summary>
        /// <param name="task"></param>
        public static void StudentTasks(int task)
        {
            Student s1 = new Student("Ivanov Ivan", Sex.male, "smp-181", 10.5, LearningType.fullTime, 75000, FamilyType.complete);
            Student s2 = new Student("Petrov Petr", Sex.male, "smp-182", 9, LearningType.distance, 54000, FamilyType.incomplete);
            Student s3 = new Student("Mukash Dinara", Sex.female, "smp-181", 11.5, LearningType.fullTime, 120000, FamilyType.complete);
            Student s4 = new Student("Ivanova Maria", Sex.female, "smp-181", 10.5, LearningType.fullTime, 100000, FamilyType.complete);
            Student s5 = new Student("Ibragim Ruslan", Sex.male, "smp-182", 8.5, LearningType.distance, 80000, FamilyType.incomplete);
            Student s6 = new Student("Kim Oleg", Sex.male, "smp-182", 11.5, LearningType.distance, 125000, FamilyType.complete);
            Student s7 = new Student("Sabirova Zhanna", Sex.female, "smp-181", 10.5, LearningType.fullTime, 90000, FamilyType.complete);
            Student s8 = new Student("Imanali Aruzhan", Sex.female, "smp-181", 11.5, LearningType.fullTime, 95000, FamilyType.complete);
            Student s9 = new Student("Pak Oleg", Sex.male, "smp-182", 9, LearningType.distance, 115000, FamilyType.incomplete);
            Student s10 = new Student("Mamin Askar", Sex.male, "smp-181", 9.5, LearningType.fullTime, 100000, FamilyType.incomplete);

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);

            if (task==1)
            {
                //1.	Общежитие в первую очередь предоставляется тем, у кого доход на члена семьи меньше двух минимальных зарплат, 
                //затем остальным в порядке уменьшения среднего балла. Отобразить данный список.
                Console.WriteLine("Имя\t\tГруппа\tСр.балл\tФорма обучения\tДоход\tСостав семьи");
                Console.WriteLine("Список на заселение в первую очередь (по доходу):\n");
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].IsLessIncome())
                        Console.WriteLine(students[i].ToString());                    
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine("Список на заселение по среднему баллу:\n");
                var ss = students.Where(x => !x.IsLessIncome());
                ss = ss.OrderByDescending(x => x.AvgMark);                
                foreach (Student i in ss)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            else if (task==2)
            {
                //2.	Вывести список очередности предоставления мест в общежитии. 
                //При этом первые 3 мест выделить зеленым цветом, вторые 3 оранжевым, остальные красным.
                var ss1 = students.Where(x => x.IsLessIncome()).OrderBy(x => x.IncomePerFamMember).ToList<Student>();
                foreach (Student j in students.Where(x => !x.IsLessIncome()).OrderByDescending(x => x.AvgMark))
                {
                    ss1.Add(j);
                }

                Console.WriteLine("Имя\t\tГруппа\tСр.балл\tФорма обучения\tДоход\tСостав семьи");
                Console.WriteLine("Список на заселение:\n");
                for (int i = 0; i < ss1.Count; i++)
                {
                    if (i<3)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (i>=3 && i<6)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ss1[i].ToString());
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (task==3)
            {
                //3.	Вывести список студентов, у которых не полная семья.
                Console.WriteLine("Имя\t\tГруппа\tСр.балл\tФорма обучения\tДоход\tСостав семьи");
                Console.WriteLine("Список студентов из неполных семей:");
                var ss = students.Where(x => x.FamilyType == FamilyType.incomplete).OrderByDescending(y=>y.AvgMark);
                foreach (Student i in ss)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            else if (task==4)
            {
                //4.	Вывести 5 студентов, отличников с самым высоким баллом.
                Console.WriteLine("Имя\t\tГруппа\tСр.балл\tФорма обучения\tДоход\tСостав семьи");
                Console.WriteLine("Список 5 студентов с самым высоким баллом:\n");
                students=students.OrderByDescending(x => x.AvgMark).ToList<Student>();
                int k = 0;
                foreach (Student i in students)
                {
                    if (k<5)
                        Console.WriteLine(i.ToString());
                    k++;
                }
            }
            else if (task==5)
            {
                //5.	Вывести 5 студентов, отличников с самым низким баллом.
                Console.WriteLine("Имя\t\tГруппа\tСр.балл\tФорма обучения\tДоход\tСостав семьи");
                Console.WriteLine("Список 5 студентов с самым низким баллом:\n");
                students = students.OrderBy(x => x.AvgMark).ToList<Student>();
                int k = 0;
                foreach (Student i in students)
                {
                    if (k<5)
                        Console.WriteLine(i.ToString());
                    k++;
                }
            }
            else if (task==6)
            {
                //6.	Вывести 3 студентов, с самым низким доходом семьи, а так у которых неполная семья
                Console.WriteLine("Имя\t\tГруппа\tСр.балл\tФорма обучения\tДоход\tСостав семьи");
                Console.WriteLine("Список 3 студентов из неполных семей с самым низким доходом:\n");
                students = students.Where(x => x.FamilyType == FamilyType.incomplete).OrderBy(x => x.IncomePerFamMember).ToList<Student>();
                int k = 0;
                foreach (Student i in students)
                {
                    if (k<3)
                        Console.WriteLine(i.ToString());
                    k++;
                }
            }
        }

        /// <summary>
        /// Задание №3 - Создайте класс Кошка...
        /// </summary>
        /// <param name="food"></param>
        public static void CatTask(Food food)
        {
            Cat c = new Cat();
            c.EatSmth(food);
            Console.WriteLine("Кошка {0} съела {1}. Уровень сытости: {2}", c.Name, food, c.SatietyLevel);
        }
    }
}
