using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class CustomException : Exception
    {
        Exception_Type type;
        public enum Exception_Type
        {
            EMPTY_EXCEPTION,NULL_EXCEPTION, CLASS_NOT_FOUND, CONSTRUCTOR_NOT_FOUND
        }

        public CustomException(Exception_Type type, string msg) : base(msg)
        {
            this.type = type;
        }
    }
}
