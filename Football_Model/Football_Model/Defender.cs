using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Model
{
    public class Defender : FootballPlayer
    {
        public Defender(string name, int age, int number, int height) : base(name, age, number, height)
        {
            Name = name;
            Age = age;
            Number = number;
            Height = height;
        }
    }
}
