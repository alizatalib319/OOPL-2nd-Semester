using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfassessment2
{
    public class calculator
    {
        public int Value1;
        public int Value2;

        public int Addition()
        {
            return Value1 + Value2;
        }
        public int Subtraction()
        {
            return Value1 - Value2;
        }
        public int Multiplication()
        {
            return Value2 * Value1; 
        }
        public int Division()
        {   
            return Value1 / Value2;
        }

    }
}
