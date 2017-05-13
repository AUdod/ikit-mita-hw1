using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cat
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == null)
                    _name = value;
            }
        }

        public DateTime Age { get; }

        private int Health = 10;

        public ConsoleColor Color
        {
            get
            {
                if (Health <= 10 && Health >= 7)
                    return ConsoleColor.Green;
                else
                if (Health < 7 && Health >= 3)
                    return ConsoleColor.Yellow;
                else
                if (Health < 3 && Health >= 1)
                    return ConsoleColor.Red;
                else
                if (Health < 1 && Health >= 0)
                    return ConsoleColor.DarkGray;
                else
                    return ConsoleColor.Magenta;
            }
        }

        public void Feed()
        {
            if (Health <= 9)
                Health += 1;
            else
                Health = 10;

        }

        public void Punish()
        {
            if (Health >= 1)
                Health -= 1;
            else
                Health = 0;
        }

        public Cat()
        {
            Age = DateTime.Now.AddMonths(-2);
        }
    }
    
}
