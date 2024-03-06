using System;


namespace DictonariesDemo
{
    internal class Program
    {
        // Key - Value
        // Auto - Car

        static void Main(string[] args)
        {
            Employee[] employess =
            {
                new Employee("CEO","Gwyn",95,200),
                new Employee("Manager","Joe",35,25),
                new Employee("HR","Lora",31,21),
                new Employee("Secretary","Petra",28,18),
                new Employee("Lead Developer","Artorias",55,35),
                new Employee("Intern","Ernest",22,8)

            };
            

            Dictionary<string,Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee employee in employess)
            {
                employeesDirectory.Add(employee.Role, employee);
            }


            //Update
            string KeyToUpdate = "HR";
            if(employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
            }

            //Remove
            string KeyToRemove = "Intern";
            if (employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Remove {0}",KeyToRemove);
            }

            string key = "CEO";
            if(employeesDirectory.ContainsKey(key))
            {
                Employee emp1 = employeesDirectory[key];
                Console.WriteLine(emp1.Role + emp1.Name + emp1.Salary);
            }
            else
            {
                Console.WriteLine("No employee found");
            }

            for(int i=0;i<employeesDirectory.Count;i++)
            {
                KeyValuePair<string,Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine("Key : {0} ",keyValuePair.Key);
                Employee employeeValue= keyValuePair.Value;
                Console.WriteLine(employeeValue.Name);
            }

            Employee result = null;
            if(employeesDirectory.TryGetValue("Intern",out result))
            {
                Console.WriteLine("Value Retrieved!");
                Console.WriteLine("Employe name:{0}",result.Name);
                
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }

            Dictionary<int, string> dic = new Dictionary<int, string>() { 
            { 1,"one"},
            { 2, "two" },
            { 3,"three"} };

            
        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public float Rate { get; set; }
        // Yearly Salaray=Rate/h * number of days * number of weeks * number of months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public Employee(string role, string name, int age,float rate)
        {
            this.Role = role; ;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}