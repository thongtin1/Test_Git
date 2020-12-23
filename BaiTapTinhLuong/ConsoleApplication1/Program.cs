using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            try
            {
                List<Employee> listProgram = new List<Employee>();
                if (File.Exists(path))
                {
                    using (var reader = new StreamReader(path))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');
                            Employee program = new Employee(values[0], values[1], values[2], values[3], values[4]);
                            listProgram.Add(program);
                        }

                    }
                }
                Caculate caculate = new Caculate();
                foreach (Employee employee in listProgram)
                {
                    Console.WriteLine("Nhan vien {0}", employee.getName());
                    Console.WriteLine("So tuoi : {0}", caculate.getAge(employee.getDob()));
                    Console.WriteLine("Nam : {0} - Thang : {1}", caculate.getYear(employee.getDob()), caculate.getMonth(employee.getDob()));
                    Console.WriteLine("Luong {0}", caculate.getSalCurrent(employee.getStartSal(), employee.getStartDate()));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
