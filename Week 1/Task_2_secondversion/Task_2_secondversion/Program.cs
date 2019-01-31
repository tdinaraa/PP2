using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_secondversion
{
    class Student //special class for Student
    {
        //global variables of class Student
        public string name; //name is identified as string
        public string id; //id is identified as string (it may consists letters and numbers)
        public int year; //year is identified as int (numbers only)


        public Student(string name, string id) //constructor with two parameters
        {
            this.name = name; //initialize variables using pointers
            this.id = id;
        }

        public void AddYear() //method that used to increse the year
        {
            this.year++;
        }

        public void ShowInfo() //method that used to access for all info about student
        {
            Console.WriteLine(name + " " + id + " " + year);
        }

        public string Name() //method to access the name
        {
            return this.name;
        }

        public string ID() //method to access the id
        {
            return this.id;
        }

        public int Year() //method to access the year
        {
            return this.year;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string name, id;
            name = Console.ReadLine();
            id = Console.ReadLine(); //data that are used

            Student st = new Student(name, id); //new object that consists the name and id of student
           
            for (int i = 0; i < 4; i++) //cycles used to output data 4 times
            {
                st.AddYear();//year is increased by 1
                Console.WriteLine(st.Name() + " " + st.ID() + " " + st.Year()); //all data are output
            }

        }
    }
}
