using System;
using System.Xml.Serialization;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
                
            };


            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }


    interface IWorker
    {
        void Work();
        

    }
    //SOLID Interface Segregation   
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("yönetici yemeğini yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("yöneticinin maaşı yattı");
        }

        public void Work()
        {
            Console.WriteLine("yönetici bugün çalıştı");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("İşçi yemeğini yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("işçi maaşı yattı");
            ;
        }

        public void Work()
        {
            Console.WriteLine("işçi bugün çalıştı");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot bugün çalıştı");
        }
    }
}

