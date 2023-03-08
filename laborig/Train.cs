using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class Train : Transport
    {
        protected string color;
        protected static string[] colorarr = { "Оранжевый", "Красный", "Зеленый", "Синий", "Коричневый" };

        [ExcludeFromCodeCoverage]
        public string Color
        {
            set
            {
                if (value is string)
                {
                    color = value;
                }
                else
                {
                    color = "";
                }
            }
            get { return color; }
        }

        [ExcludeFromCodeCoverage]
        public string this[int index] // whyyy
        {
            get
            {
                if (index >= 0 && index < colorarr.Length)
                {
                    return colorarr[index];
                }
                else
                {
                    return null;
                }
            }
        }

        public Train(int wheels, int doors, string color) :base(wheels, doors)
        {
            {
                Color = color;
            }
        }
        public Train() : base()
        {

        }



        public override void RandomInit()
        {
            base.RandomInit();
            Color = colorarr[rnd.Next(0, 5)];

        }

        [ExcludeFromCodeCoverage]
        public override bool Equals(object obj)
        {
            if (obj is Train s)
            {
                return this.Wheels == s.Wheels & this.Doors == s.Doors & this.Color == s.Color;
            }
            else
            {
                return false;
            }
        }

        public override void Show()
        {
            base.Show(); Console.WriteLine($"Цвет транспортного средства: {Color}");
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

            Console.WriteLine("Введите цвет т/с");

            Color = Console.ReadLine();

        }
    }
}
