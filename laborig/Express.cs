using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class Express : Train
    {
        protected int capacity;

        protected int passangers;

        [ExcludeFromCodeCoverage]
        public int Capacity
        {
            set
            {
                if (value >= 0)
                {
                    capacity = value;
                }
                else
                {
                    capacity = 0;
                }
            }
            get { return capacity; }
        }

        [ExcludeFromCodeCoverage]
        public int Passangers
        {
            set
            {
                if (value >= 0)
                {
                    passangers = value;
                }
                else
                {
                    passangers = 0;
                }
            }
            get { return passangers;}
        }


        public Express(int wheels, int doors, string color, int capacity) : base(wheels, doors, color)
        {
            {
                Capacity = capacity;
            }
        }

        public Express():base()
        {

        }
        [ExcludeFromCodeCoverage]
        public override void Show2()
        {
            Console.WriteLine("Сколько вагонов будет в экспрессе?");

            int u = Input.ReadInt();

            Passangers = rnd.Next(1, 500);
            Console.WriteLine($"Вместимость одного вагона {Passangers} чел");
            Console.WriteLine($"Кол-во пассажиров во всех вагонах: {Passangers * u} чел");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Расчет идет с с условием полного заполнения вогонов");
            Console.ForegroundColor = ConsoleColor.White;

        }
        public override void RandomInit()
        {
            base.RandomInit();
            Capacity = rnd.Next(1, 500);
        }

        [ExcludeFromCodeCoverage]
        public override bool Equals(object obj)
        {
            if (obj is Express s)
            {
                return this.Wheels == s.Wheels & this.Doors == s.Doors & this.Color == s.Color & this.Capacity == s.Capacity;
            }
            else
            {
                return false;
            }
        }

        public override void Show()
        {
            base.Show(); Console.WriteLine($"Кол-во мест в т/с: {Capacity}");
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

            Console.WriteLine("Введите кол-во мест в т/с");

            Capacity = Input.ReadInt();
        }
    }
}
