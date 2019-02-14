using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Student
{
    class Student //отдельный класс студентов
    {
        //глобальные переменные класса
        public string name; 
        public string id; 
        public int year; 

        public Student(string name, string id) //конструктор с двумя параметрами
        {
            this.name = name; //переменные инициализируются при помощи указателя
            this.id = id; 
        }

        public void Addyear() //метод, используемый для увелечения года
        {
            this.year++; 
        }

        public void PrintInfo () //метод, используемый для вывода данных
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
            Student st = new Student("Kamilla", "18BD112100"); //параметр содержащий данные студента
            st.year = 1; 
            st.Addyear(); //год увеличивается

            st.PrintInfo(); //вывод всех данных
            
        }
    }
}

