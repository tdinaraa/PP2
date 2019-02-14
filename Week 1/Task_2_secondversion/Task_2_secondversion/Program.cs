using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_secondversion
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

        public void AddYear() //метод, используемый для увелечения года
        {
            this.year++;
        }

        public void ShowInfo() //метод, используемый для выода всей информации
        {
            Console.WriteLine(name + " " + id + " " + year);
        }

        public string Name() //метод, используемый для доступа к имени
        {
            return this.name;
        }

        public string ID() //метод, используемый для доступа к айди
        {
            return this.id;
        }

        public int Year() //метод, используемый для доступа к году обучения
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
            id = Console.ReadLine(); //данные, используемые для считывания инфрмации консольем 

            Student st = new Student(name, id); //новый объект, использующий имя и айди

            for (int i = 0; i < 4; i++) //цикл для вывода данных
            {
                st.AddYear(); //каждый раз год увеличивается
                Console.WriteLine(st.Name() + " " + st.ID()+ " " + st.Year()); //все данные выводятся
            }

        }
    }
}
