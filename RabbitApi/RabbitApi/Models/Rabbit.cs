using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitApi.Models
{
    public enum FurColors
    {
        White = 1,
        Brown,
        Black,
        Grey
    }
    public enum EyeColors
    {
        Blue = 1,
        Black,
        Red
    }
    public enum Genders
    {
        Male = 1,
        Female
    }
    public class Rabbit
    {

        [Required]
        [EnumDataType(typeof(FurColors))]
        public FurColors FurColor { get; set; }

        [Required]
        [EnumDataType(typeof(EyeColors))]
        public EyeColors EyeColor { get; set; }

        [Required]
        [EnumDataType(typeof(Genders))]
        public Genders Genders { get; set; }

        [Required]
        public int Age { get; set; }

    }

    
}
