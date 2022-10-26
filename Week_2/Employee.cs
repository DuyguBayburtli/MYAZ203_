using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Employee
    {

        private string _firstName;
        private string _lastName;


        private List<Employee> _list;
        public int Id { get; set; }

        public string FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            // expresssion-bodied propert accesors
            get => _lastName;
            set => _lastName = value;

        }

        public int Age { get; set; }

        public Employee()
        {
            _list = new List<Employee>();

        }

        // overloading
        public Employee(string firstName, string lastName, int age, int id)
        {
            _list = new List<Employee>();

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Id = id;
        }

        public override string? ToString()
        {
            return $"{FirstName} {LastName} ({Age}) ({Id}) ";
        }

        public void Add(Employee employee)
        {
            _list.Add(employee);
        }

        public void Remove(int id)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Id == id)
                {
                    var emp = _list[i];
                    _list.Remove(emp);
                    return;
                }
            }
            throw new Exception("Eleman bulunamadı");
        }

        public void AddRange(params Employee[] employees)
        {
            _list.AddRange(employees);
        }

        public List<Employee> GetEmployees() => _list;

        public void ShowAll()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
