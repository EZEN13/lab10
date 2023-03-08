using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class Avto : Transport
    {
        protected double oil;
        protected int horsepower;
        protected int wheelsweight;
        protected int doorsweight;

        [ExcludeFromCodeCoverage]
        public double OIL
        {
            set
            {
                if (value >= 0)
                {
                    oil = value;
                }
                else
                {
                    oil = 0;
                }
            }
            get { return oil; }
        }
        [ExcludeFromCodeCoverage]
        public int HorsePower
        {
            set
            {
                if (value >= 0)
                {
                    horsepower = value;
                }
                else
                {
                    horsepower = 0;
                }
            }
            get { return horsepower; }
        }

        [ExcludeFromCodeCoverage]
        public int Doorsweight
        {
            set
            {
                if (value >= 0)
                {
                    doorsweight = value;
                }
                else
                {
                    doorsweight = 0;
                }
            }
            get { return doorsweight; }
        }

        [ExcludeFromCodeCoverage]
        public int Wheelsweight
        {
            set
            {
                if (value >= 0)
                {
                    wheelsweight = value;
                }
                else
                {
                    wheelsweight = 0;
                }
            }
            get { return wheelsweight; }
        }

        public Avto(int wheels, int doors, double oil, int horsepower) : base(wheels, doors)
        {
            {
                OIL = oil;
                HorsePower = horsepower;
            }
        }

        public Avto() : base()
        {

        }

        [ExcludeFromCodeCoverage]
        public override void Show2()
        {
            Console.WriteLine("Сколько колес вы хотите взвесить?");
            int k = Input.ReadInt();
            Console.WriteLine("Сколько дверей вы хотите взвесить?");
            int y = Input.ReadInt();

            Wheels = rnd.Next(1, 11);
            Doors = rnd.Next(1, 75);

            Wheelsweight = Wheels * k;

            Doorsweight = Doors * y;
            Console.WriteLine($"Вес одноко колеса автомобиля {Wheels}кг, Вес одной двери автомобиля: {Doors} кг");
            Console.WriteLine($"Вес колес автомобиля: {Wheelsweight} кг, Вес дверей автомобиля: {Doorsweight} кг");
        }

        public override void RandomInit()
        {
            base.RandomInit();
            OIL = rnd.NextDouble() * 25;
            HorsePower = rnd.Next(10,500);
        }

        [ExcludeFromCodeCoverage]
        public override bool Equals(object obj)
        {
            if (obj is Avto s)
            {
                return this.Wheels == s.Wheels & this.Doors == s.Doors & this.OIL == s.OIL & this.HorsePower == s.HorsePower;
            }
            else
            {
                return false;
            }
        }

        public override void Show()
        {
            base.Show(); 
            Console.WriteLine($"Кол-во топлива в т/c: {OIL} л.");
            Console.WriteLine($"Кол-во лош сил в т/c: {HorsePower} л.с.");
        }

        [ExcludeFromCodeCoverage]
        public override Type GetType(object obj)
        {
            return obj.GetType();
        }

        [ExcludeFromCodeCoverage]
        public override void Init()
        {
            base.Init();

            Console.WriteLine("Введите кол-во топлива т/с");

            OIL = Input.ReadDouble();

            Console.WriteLine("Введите кол-во лош. сил  т/с");

            HorsePower = Input.ReadInt();
        }


    }
}

