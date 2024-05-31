namespace Exeption
{
    public class Program
    {
        static void Main(string[] args)
        {

            //        List<int> integars = new List<int>();
            //        Console.WriteLine("enter numbers to  list of 4 integars");
            //        integars.Add(int.Parse(Console.ReadLine()));
            //        integars.Add(int.Parse(Console.ReadLine()));
            //        integars.Add(int.Parse(Console.ReadLine()));
            //        integars.Add(int.Parse(Console.ReadLine()));

            //        for (int i = 0; i < 4; i++)
            //        {

            //            for (int j = i+1; j <4; j++)
            //            {
            //                //int first = integars[0]
            //                if (integars[i] == integars[j])
            //                {
            //                    throw new ArithmeticException($"the number is dublicated:{integars[i]}");
            //                }

            //            }
            //        }
            //        Console.WriteLine("correct list");


             

            void CheckVowel(string str)
            {
              
                string vowel = "aeiouAEIOU";
                foreach (var v in vowel)
                {
                    if (str.Contains(v))
                    {
                        throw new Exception("the string have vowels");
                    }
                    
                }
                Console.WriteLine("the string haven't vowels");
            }

          CheckVowel("sara");













      }
    }
    
}
