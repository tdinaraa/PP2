using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Student
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

        public void Addyear()
        {
            this.year++; //method that used to increase the year
        }

        public void PrintInfo () //method that used to print all info about student
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(year); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Kamilla", "18BD112100"); //st parameter consists data of new student
            st.year = 1; //year of student is equal to 1
            st.Addyear(); //year is increased to one by using above method

            st.PrintInfo(); //all data is printed by using above method
            

        }
    }
}

