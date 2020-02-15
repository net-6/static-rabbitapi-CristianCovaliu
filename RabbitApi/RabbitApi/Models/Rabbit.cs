using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitApi.Models
{
    public class Rabbit
    {
        public enum FurColors
        {
            White,
            Brown,
            Black,
            Grey
        }
        public enum EyeColors
        {
            Blue,
            Black,
            Red
        }
        public enum Gender
        {
            Male,
            Female
        }
        private FurColors furColor;
        private EyeColors eyeColor;
        private Gender gender;
        private readonly DateTime dateOfBirth;
        public Rabbit(FurColors furColors, EyeColors eyeColor, Gender gender)
        {
            dateOfBirth = DateTime.Now;
        }
        public void Move()
        {
            Console.WriteLine("The rabbit is moving left and right like crazy.");
        }
        public void Sleep()
        {
            Console.WriteLine("The rabbit is sleeping like a rock.");
        }
        public void Eat()
        {
            Console.WriteLine("The rabbit is eating some food");
        }
        public int Age
        {
            get { return (DateTime.Now - dateOfBirth).Days / 365; }
        }
    }
}
