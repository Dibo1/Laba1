using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Laba1
{
    public class Ball : Ivalidatable
    {
        [Range (150, 200)]
        public int Weight { get; set; }
        [Range (65, 67)]
        public int Diameter { get; set; }
        
        public Ball (int weight, int diameter ) 
        {
            Weight = weight;
            Diameter = diameter;
        } 
    }
}
