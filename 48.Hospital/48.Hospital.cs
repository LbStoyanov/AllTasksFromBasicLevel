using System;

namespace _48.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var periodForCalculations = int.Parse(Console.ReadLine());
            var treatedPatients = 0;
            var untreatedPatients = 0;
            
            var doctors = 7;


            for (int i = 1; i <= periodForCalculations; i++)
            {
                var currentNumberOfPatients = int.Parse(Console.ReadLine());
                if ((periodForCalculations % 3 == 0) && (untreatedPatients > treatedPatients))
                {
                    doctors++;
                }
                if (currentNumberOfPatients > doctors)
                {
                    untreatedPatients += currentNumberOfPatients - doctors;
                    treatedPatients += doctors;
                    
                }
                else
                {
                    treatedPatients += currentNumberOfPatients;
                   
                }
                
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
