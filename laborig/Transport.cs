using Microsoft.SqlServer.Server;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClasLibraryLab10;

namespace ClassLibraryLab10
{
    public class Transport: Iinit, IComparable, ICloneable
    {
        public static Random rnd = new Random();
        protected int wheels;
        protected int doors;

        [ExcludeFromCodeCoverage]
        public int Wheels
        {
            set
            {
                if (value >= 0)
                {
                    wheels = value;
                }
                else
                {
                    wheels = 0;
                }
            }
            get { return wheels; }
        }

        [ExcludeFromCodeCoverage]
        public int Doors
        {
            set
            {
                if (value >= 0)
                {
                    doors = value;
                }
                else
                {
                    doors = 0;
                }
            }
            get { return doors; }
        }

        public Transport(int wheels, int doors)
        {
            Wheels = wheels;
            Doors = doors;
        }

        public Transport()
        {

        }

        public virtual void Show2()
        {
            Console.WriteLine(" ");
        }

        public virtual void RandomInit()
        {
            Wheels = rnd.Next(1, 10);
            Doors = rnd.Next(1, 10);
        }

        [ExcludeFromCodeCoverage]
        public override bool Equals(object obj)
        {
            if (obj is Transport s)
            {
                return this.Wheels == s.Wheels & this.Doors == s.Doors;
            }
            else
            {
                return false;
            }
        }

        public virtual void Show()
        {
            Console.WriteLine(this.ToString());
        }

        [ExcludeFromCodeCoverage]
        public virtual Type GetType(object obj)
        {
            return obj.GetType();
        }

        [ExcludeFromCodeCoverage]
        public virtual void Init()
        {
            Console.WriteLine("Введите кол-во колес:");

            Wheels = Input.ReadInt();

            Console.WriteLine("Введите кол-во дверей");

            Doors = Input.ReadInt();
        }



        public override string ToString()
        {
            return $"Кол-во колес: {Wheels}, Кол-во дверей: {Doors}";
        }

        [ExcludeFromCodeCoverage]
        public int CompareTo(object obj)
        {
            if (!(obj is Transport transport))
            {
                return -1;
            }
            return ((Transport)obj).Doors.CompareTo(Doors);
        }


        [ExcludeFromCodeCoverage]
        public static void FindMyObject(Array myArr, object myObject)
        {
            int myIndex = Array.BinarySearch(myArr, myObject);
            if (myIndex < 0)
            {
                Console.WriteLine("Объект для поиска ({0}) не найден. Следующий более крупный объект находится с индексом {1}.", myObject, ~myIndex);
            }
            else
            {
                Console.WriteLine("Объект для поиска ({0}) находится по индексу {1}.", myObject, myIndex);
            }
        }

        [ExcludeFromCodeCoverage]
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        [ExcludeFromCodeCoverage]
        public object Clone()
        {
            return new Transport(Wheels, Doors);
        }
    }
}
