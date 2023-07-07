﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyse(string className, string constructor)
        {

            if (className.Equals(constructor))
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.Exception_Type.CONSTRUCTOR_NOT_FOUND, "Constructor not found");

                }
            }
            else
            {
                throw new CustomException(CustomException.Exception_Type.CLASS_NOT_FOUND, "Class not Found");
            }
        }
    }
}
