    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static string ToShortDate(DateTime d) {
               return d.ToString("d");
            }
            
             public static string ToFrenchFullDate(DateTime d) {
                return d.ToString("dd/MM/yyyy HH:mm");
            }
        }
    }