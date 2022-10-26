using System;

namespace Week_2
{
    class Program
    {


        static void Main(string[] args)
        {


            var employee = new Employee();
            var _record = new Employee("Ahmet", "yılmaz", 40, 1);
            employee.Add(_record);

            employee.AddRange(
                new Employee("merve", "aslan", 45, 2),
                new Employee("edanur", "koroglu", 32, 3),
                new Employee("duygu", "bayburtlı", 23, 4),
                new Employee("rumi", "clk", 27, 5),
                new Employee("merve", "kaplan", 44, 6)
                );

            var list = employee.GetEmployees();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            employee.Remove(4);
            employee.ShowAll();

            //employee.Add(new Employee() { FirstName="Ahmet",LastName="koroglu",Age=40});
            Console.ReadLine();

            //int[] employees1 = new int[10];

            //employees1[0] = 11;
            //employees1[1] = 25;
            //employees1[2] = 34;
            //employees1[3] = 45;
            //employees1[4] = 46;
            //employees1[5] = 49;
            //employees1[6] = 54;
            //employees1[7] = 94;
            //employees1[8] = 34;
            //employees1[9] = 44;

            //int[] employees1 = { 17, 26, 24, 16, 45, 54, 65, 45, 46, 89 };

            //int max = employees1[0];


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(employees1[i]);
            //
            //    if(employees1[i] > max)
            //        max = employees1[i];
            //}
            //Console.WriteLine("max num: {0}",max);


            //Employee employee = new Employee();
            //employee.FirstName = "Ahmet";
            //employee.LastName = "Türkoğlu";
            //employee.Age = 25;


            //List<int> employees2 = new List<int>();

            //employees2.Add(5);
            //employees2.Add(23);
            //employees2.Add(56);
            //employees2.Add(27);
            //employees2.Add(28);
            //employees2.Add(29);
            //employees2.Add(12);
            //employees2.Add(72);
            //employees2.Add(32);
            //employees2.Add(22);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(employees2[i]);
            //    employees2.Sort();
            //    employees2.Reverse();

        }





    }
}

