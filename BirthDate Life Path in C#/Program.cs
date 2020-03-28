using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("       Display Users Life Path         ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Note: Enter number only\n");

            Console.WriteLine("Enter your BirthDate");
            

            try
            {
                BirthDate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

                     
            Console.ReadKey();

        }
        public static void BirthDate()
        {

            //Month
            int sum = 0, remainder;
            Console.Write("Month: ");
            int number = Int32.Parse(Console.ReadLine());

                while (number > 0)
                {
                    remainder = number % 10;
                    sum = sum + remainder;
                    number = number / 10;

                    if (sum == 10)
                    {
                        sum = 1;
                    }

                }


            //Day
            Console.Write("Day: ");
            int number2 = Int32.Parse(Console.ReadLine());

            int sum2 = 0, remainder2;

                while (number2 > 0)
                {
                    remainder2 = number2 % 10;
                    sum2 = sum2 + remainder2;
                    number2 = number2 / 10;

                    if (sum2 == 10)
                    {
                        sum = 1;
                    }
                }

            //Year
            Console.Write("Year: ");
            int number3 = Int32.Parse(Console.ReadLine());

            int sum3 = 0, remainder3;


                while (number3 > 0)
                {
                    remainder3 = number3 % 10;
                    sum3 = sum3 + remainder3;
                    number3 = number3 / 10;

                    if (sum3 >= 10)
                    {
                        while (sum3 > 0)
                        {
                            remainder3 = sum3 % 10;
                            number3 = number3 + remainder3;
                            sum3 = sum3 / 10;
                        }
                    }
                }

            Console.WriteLine("Sum of the day is: " + sum);
            Console.WriteLine("Sum of the day is: " + sum2);
            Console.WriteLine("Sum of the year is: " + sum3);

            int LifePath = sum + sum2 + sum3;
            if (LifePath == 10)
            {
                LifePath = 1;
            }
            Console.WriteLine("\nYour Life Path Number is: " + LifePath);

           
            if(LifePath == 1)
            {
                Console.WriteLine("The Natural Born Leader");
                Console.Write("\nThe Life Path 1 is one of leadership and trailblazing. " +
                    "With a strong sense of independence, you do not like relying on other people, " +
                    "especially if you feel they are holding you back. Often, you may feel " +
                    "like it is better to go it alone. ");
            }else if(LifePath == 2)
            {
                Console.WriteLine("The Diplomat");
                Console.Write("\nAs a Life Path 2 you will find yourself attracted to a" +
                    " life of building and nurturing relationships. You bring unity and" +
                    " compassion to the world with your big heart and have a tendency to" +
                    " bring out the good in people in your life. ");
            }else if(LifePath == 3)
            {
                Console.WriteLine("The Creative");
                Console.Write("\nPeople with a Life Path 3 are the most artistic in the bunch. " +
                    "You find ways of creating the most beautiful things in this world such as art," +
                    " music, literature, etc. You breathe life into culture, and make it seem so simple" +
                    " because of your natural gift for expression. This explains why the entertainment " +
                    "industry is chock full of Life Path 3's. Noteworthy examples include: Chris Rock," +
                    " Jackie Chan, Jamie Foxx, Nelly Furtado, Snoop Dogg, and Rihanna to name a few.  ");

            }
            else if (LifePath == 4)
            {
                Console.WriteLine("The Worker");
                Console.Write("\nThe life of a Life Path 4 is one of work and discipline to feel stable." +
                    " You do not like taking short-cuts and often feel that the best way to do anything " +
                    "is through dedications and perseverance. You can see through Get Rich Quick "+
                    " schemes and consider them to be a waste of time, you see that time as being better " +
                    "spent working towards the solid goal.  ");
            }
            else if (LifePath == 5)
            {
                Console.WriteLine("The Flexible Five");
                Console.Write("\nthe Life Path 5 loves to have variety in life." +
                    " Anything new is exciting. Whether it is traveling to a " +
                    "place you've never been, or meeting new people, you are always" +
                    " looking for that next experience and adventure. ");
            }
            else if (LifePath == 6)
            {
                Console.WriteLine("The Harmonizer");
                Console.Write("\nThe Life Path 6 looks for ways to make harmony with" +
                    " everything you encounter. Whether it is art, music, or relationships," +
                    " no other Life Path can make things coalesce as naturally as you can." +
                    " Your magnetic personality draws people in and can lead to you being the " +
                    "center of attention.  ");
            }
            else if (LifePath == 7)
            {
                Console.WriteLine("Seeker of Knowledge");
                Console.Write("\nAs a Life Path 7 you are always looking for the answers." +
                    " Whether the question is big or small, doesn't matter, it’s the glory" +
                    " of finding the answer that drives you. This can lead to some interesting " +
                    "journeys during your life since you tend to seek spiritual or inner self" +
                    " understanding.  ");
            }

            else if (LifePath == 8)
            {
                Console.WriteLine("The Powerhouse");
                Console.Write("\nAs a Life Path 8 you are alive to make an impact on the world " +
                    "through your drive and ambition. You are a person of authority, and material" +
                    " wealth. You will often master the art of being successful in the career" +
                    " of your choosing.  ");
            }
            else if (LifePath == 9)
            {
                Console.WriteLine("You Bring Beauty To Your Surroundings");
                Console.Write("\nYou are imaginative and creative, especially at harmoniously " +
                    "arranging the beauty already potential in the environment. These abilities" +
                    " can lead you into such fields as interior decorating, landscape art, and" +
                    " photography. But because of your strong social consciousness, you can be an" +
                    " effective politician, lawyer, judge, minister, teacher, healer, and environmentalist." +
                    " Vocations that require self- sacrifice and have a clear social impact are common among 9s. ");
            }
            else if (LifePath == 11)
            {
                Console.WriteLine("The Healer");
                Console.Write("\nYou know you’re different, you don’t need other people to tell you" +
                    " that. As a Life Path 11, life is filled with mysterious connections and " +
                    "experiences that just seem to pop up. You’re more intuitive, or sensitive," +
                    " than other people you know. ");
            }
            else if (LifePath == 22)
            {
                Console.WriteLine("The Master Builder");
                Console.Write("\nThe Life Path 22 is one of the most powerful and influential paths in numerology." +
                    " Your own abilities may seem overwhelming at times, and difficult to manage, but learning to" +
                    " harness your gifts will allow you greater control over your destiny, and in some cases, the destiny" +
                    " of others. This may cause you to feel as though a heavy burden rests on your shoulders. Be careful " +
                    "not to take on too much at once. And at the same time, don’t be afraid to challenge yourself. ");
            }


        }
     }  
}
