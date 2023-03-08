using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ClassLibraryLab10;

namespace Main_File_Laba10
{
    internal class Program
    {
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 часть лабораторной работы");
            Console.WriteLine("\nОбычное инициализирование объектов:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nВведите кол-во колес: ");
            int wheels = Input.ReadInt();

            Console.WriteLine("Введите кол-во дверей: ");
            int doors = Input.ReadInt();

            Console.WriteLine("Введите объем топлива: ");
            double oil = Input.ReadDouble();

            Console.WriteLine("Введите кол-во л.c.: ");
            int horsepower = Input.ReadInt();

            Console.WriteLine("Введите цвет т/с");
            string color = Console.ReadLine();

            Console.WriteLine("Введите кол-во мест в т/с");
            int capacity = Input.ReadInt();

            Transport transport1 = new Transport(wheels, doors);

            Train train1 = new Train(wheels, doors, color);


            Avto avto1 = new Avto(wheels, doors, oil, horsepower);


            Express express1 = new Express(wheels, doors, color, capacity);


            Transport[] transport = { transport1, train1, avto1, express1 };
            foreach (Transport s in transport)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Информация о т/с: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                s.Show();
            }



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВвод с помощью метода Init");

            Transport transport3 = new Transport();
            Train train3 = new Train();
            Avto avto3 = new Avto();
            Express express3 = new Express();



            Transport[] transportinit = { transport3, train3, avto3, express3 };
            foreach (Transport s in transportinit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Информация о т/с: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                s.Init();
                s.Show();
                Console.WriteLine(" ");
            }

            Transport transport4 = new Transport();
            Avto avto4 = new Avto();
            Train train4 = new Train();
            Express express4 = new Express();

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Информация о т/c с помощью метода RandomInit");


            Transport[] transportrandominit = { transport4, avto4, train4, express4 };
            foreach (Transport s in transportrandominit)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Инфрмация о вашем т/с");
                s.RandomInit();
                s.Show();
                Console.WriteLine(" ");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2 Часть Лабораторной работы");

            Transport transport5 = new Transport();
            Avto avto5 = new Avto();
            Express express5 = new Express();

            Transport[] transports = { transport5, avto5, express5 };

            foreach (Transport s in transports)
            {
                if (s is Transport)
                {
                    s.Show2();
                    Console.WriteLine(" ");
                }
                else if (s is Avto)
                {
                    s.Show2();
                    Console.WriteLine(" ");
                }
                else if (s is Express)
                {
                    s.Show2();
                    Console.WriteLine(" ");
                }
            }

            Avto avto6 = new Avto();
            Avto avto7 = new Avto();
            Avto avto8 = new Avto();
            Avto avtobighorse = new Avto(0,0,0,0);
            Avto[] avtos = { avto6, avto7, avto8 };
            int index = 0;
            int horses = 0;
            Console.WriteLine("Создано 3 т/с");
            foreach (Avto s in avtos)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Инфрмация о вашем т/с");
                s.RandomInit();
                s.Show();
                Console.WriteLine(" ");
            }
            foreach (Avto s in avtos)
            {
                if (s.HorsePower > avtobighorse.HorsePower)
                    {
                    avtobighorse = s;
                    index = Array.IndexOf(avtos, s)+1;
                    horses = s.HorsePower;
                    }
            }

            Console.WriteLine($"\nБольше всего лошадиных сил({horses}) у машины {index} :");
            avtobighorse.Show();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n3 часть Лабораторной работы");
            Console.WriteLine("\nСортировка колес ICompare");
            Console.ForegroundColor = ConsoleColor.White;

            Transport transportwheel = new Transport();
            transportwheel.RandomInit();

            Train trainwheel = new Train();
            trainwheel.RandomInit();

            Avto avtowheel = new Avto();
            avtowheel.RandomInit();

            Express expresswheel = new Express();
            expresswheel.RandomInit();

            Transport[] wheelsarray = { transportwheel, avtowheel, trainwheel, expresswheel };

            Console.WriteLine("\nСортировка по колесам:");

            Array.Sort(wheelsarray, new SortByWheels());

            foreach (var item in wheelsarray)
            {
                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nБинарный поиск элемента");
            Console.ForegroundColor = ConsoleColor.White;
            Transport.FindMyObject(wheelsarray, transportwheel);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nСортировка дверей IComparable\n");
            Console.ForegroundColor = ConsoleColor.White;

            Transport transportdoors = new Transport();
            transportdoors.RandomInit();

            Train traindoors = new Train();
            traindoors.RandomInit();

            Avto avtodoors = new Avto();
            avtodoors.RandomInit();

            Express expressdoors = new Express();
            expressdoors.RandomInit();

            Transport[] doorsarray = { transportdoors, traindoors, avtodoors, expressdoors };

            Array.Sort(doorsarray);

            foreach (var item in doorsarray)
            {
                Console.WriteLine(item);
            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nКопирование:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Transport transport6 = new Transport();
            transport6.RandomInit();

            Transport transport7 = new Transport();
            transport7.RandomInit();
            transport7.Wheels = 100;
            transport6 = (Transport)transport7.ShallowCopy();
            
            Console.WriteLine(transport6);
            Console.WriteLine(transport7);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nКлонирование:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Transport transport8 = new Transport();
            transport8.RandomInit();

            Transport transport9 = new Transport();
            transport9.RandomInit();

            transport8 = (Transport)transport9.Clone();
            transport9.Wheels = 100;
            Console.WriteLine(transport8);
            Console.WriteLine(transport9);
            Console.ReadKey();
        }
    }
}
