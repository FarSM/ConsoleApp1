using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TestQuestions
    {
        public static void Main()
        {
            Questions Question1 = new Questions();
            Question1.Q = "\n1. What are the number of continents present? \n   Click on the right option a/b/c \n\ta) 9\n\tb) 6\n\tc) 7 ";
            Question1.RightAnswer = 'c';

            Questions Question2 = new Questions();
            Question2.Q = "\n2. What does a.m stand for? \n   Click on the right option a/b/c \n\ta) Ante Meridiem\n\tb) After Midday\n\tc) Anno Tomini ";
            Question2.RightAnswer = 'a';

            Questions Question3 = new Questions();
            Question3.Q = "\n3. How do we write 50 in Roman Numerals? \n   Click on the right option a/b/c \n\ta) L\n\tb) C\n\tc) X ";
            Question3.RightAnswer = 'a';

            Questions Question4 = new Questions();
            Question4.Q = "\n4. Which is the largest state in India? \n   Click on the right option a/b/c \n\ta) Maharashtra\n\tb) Madhya Pradesh\n\tc) Rajasthan ";
            Question4.RightAnswer = 'c';

            Questions Question5 = new Questions();
            Question5.Q = "\n5. What is the most spoken language in the world? \n   Click on the right option a/b/c \n\ta) Hindi\n\tb) English\n\tc) Mandarin Chinese ";
            Question5.RightAnswer = 'b';


            List<Questions> list = new List<Questions>();
            list.Add(Question1);
            list.Add(Question2);
            list.Add(Question3);
            list.Add(Question4);
            list.Add(Question5);


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Q + "\n" + item.RightAnswer);
            //}

            int count = 0;
            int score = 0;
            char Option = 'Y';

            while (Option == 'Y')
            {
                Console.Write("Do you want to answer the question? Type Y or N :");
                char Choice = Convert.ToChar(Console.ReadLine());
                switch (Choice)
                {
                    case 'Y':
                        Console.WriteLine(list[count].Q);
                        char Ans = Convert.ToChar(Console.ReadLine());
                        if (Ans == list[count].RightAnswer)
                        {
                            score++;
                        }
                        count++;

                        if(count == 5)
                        {
                            Option = 'N';
                            Console.WriteLine("\nYour score is {0}/{1}", score, count);
                        }else Option = 'Y';
                        break;

                    case 'N':
                        Console.WriteLine("\nYour score is {0}/{1}", score, count);
                        Option = 'N';
                        break;

                    //case 'F':
                    //    Console.WriteLine("TEST");
                    //    break;

                    default:
                        Console.WriteLine("\nWrong option entered", score);
                        break;


                }

            }


        }

        public class Questions
        {
            public string Q { get; set; }
            public char RightAnswer { get; set; }
        }
    }
}
