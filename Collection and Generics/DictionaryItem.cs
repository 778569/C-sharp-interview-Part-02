using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_and_Generics

{
    public class DictionaryItem
    {

        public string name;

        public int id;

        public string department;

        public DictionaryItem(string name, int id, string depertment)
        {
            this.name = name;
            this.id = id;
            this.department = depertment;
        }
        public void Test()
        {
            DictionaryItem employee1 = new DictionaryItem("Kavinda", 3695, "IT");
            DictionaryItem employee2 = new DictionaryItem("Samantha", 3696, "BA");
            DictionaryItem employee3 = new DictionaryItem("Shakuni", 3697, "QA");

            Dictionary<int, DictionaryItem> employeeById = new Dictionary<int, DictionaryItem>();

            employeeById.Add(employee1.id, employee1);
            employeeById.Add(employee2.id, employee2);
            employeeById.Add(employee3.id, employee3);

            DictionaryItem employee;

            if (employeeById.TryGetValue(3695, out employee))
            {
                Console.WriteLine(employee.name + " : " + employee.department);
            }

           int n = 100;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Convert.ToString(i,2));
            }
        }
    }
}
