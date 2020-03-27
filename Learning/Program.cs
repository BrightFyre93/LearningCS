using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning
{
    class Program
    {
        static void Main()
        {
            //DriverLicense();
            //CheerCreator();
            //SkeeBall();
            //PaintCost();
            //DejaVu();
            //RemoveSpaces();
            //GapfulNumber();

            //Matches();
        }
        static void CheerCreator()
        {
            int yard_input = Convert.ToInt32(Console.ReadLine());
            if (yard_input > 10)
            {
                Console.WriteLine("High Five");
            }
            else if (yard_input >=1)
            {
                string temp = "";
                for(int i = 0;i<yard_input;i++)
                {
                    temp += "Ra!";
                }
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("shh");
            }
            Console.ReadKey();
        }
        static void DriverLicense()
        {
            string my_name = Console.ReadLine();
            int number_of_agents = Convert.ToInt32(Console.ReadLine());
            string[] array_number_of_people = Console.ReadLine().Split(new char[] { ' ' });
            List<string> list_number_of_people = array_number_of_people.ToList();
            list_number_of_people.Add(my_name);
            list_number_of_people.Sort();
            int index_my_name = list_number_of_people.IndexOf(my_name);
            int my_time_to_shine = (((index_my_name) / number_of_agents) * 20) + 20;
            Console.WriteLine(my_time_to_shine);
            Console.ReadKey();
        }
        static void SkeeBall()
        {
            int points = Convert.ToInt32(Console.ReadLine());
            int squirt_price = Convert.ToInt32(Console.ReadLine());
            if((points/12) >= squirt_price)
            {
                Console.WriteLine("Buy it!");
            }
            else
            {
                Console.WriteLine("Try again");
            }
            Console.ReadKey();
        }
        static void PaintCost()
        {
            int number_of_paints = Convert.ToInt32(Console.ReadLine());
            int final_cost = Convert.ToInt32((40 + 5 * number_of_paints) * 1.1);
            Console.WriteLine(final_cost);
        }
        static void DejaVu()
        {
            string input_string = Console.ReadLine();
            Boolean flag = false;
            char[] char_array = input_string.ToCharArray();
            for(int i = 0;i<input_string.Length;i++)
            {
                if(flag)
                {
                    Console.WriteLine("Deja Vu");
                    break;
                }
                for(int j=i+1;j<input_string.Length;j++)
                {
                    if(char_array[i] == char_array[j])
                    {
                        flag = true;
                        break;
                    }
                }
                
            }
            if (!flag)
            {
                Console.WriteLine("Unique");
            }
            Console.ReadKey();
        }
        static void RemoveSpaces()
        {
            Console.WriteLine("Enter a string: ");
            string input_string = Console.ReadLine();
            char[] char_array = input_string.ToCharArray();
            string new_string = input_string;
            while(true)
            {
                int indexOfSpace = Array.IndexOf(char_array, ' ');
                if(indexOfSpace == -1)
                {
                    break;
                }
                else
                {
                    new_string = new_string.Substring(0, indexOfSpace) + new_string.Substring(indexOfSpace + 1);
                }
                char_array = new_string.ToCharArray();

            }
            Console.WriteLine($"New String: {new_string}");
            Console.ReadKey();
        }
        static void GapfulNumber()
        {
            Console.WriteLine("Enter a 3 digit Number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int divisor = 0;
            divisor += input % 10 + ((input - (input%100))/10);
            if (input % divisor == 0)
            {
                Console.WriteLine("Gapful Number");
            }
            else
            {
                Console.WriteLine("Not a Gapful Number");
            }
            Console.ReadKey();
        }
        static void TransactionLogs()
        {
            List<string> Months = new List<string>();
            List<string> Reasons = new List<string>();
            List<int> Values = new List<int>();
            List<string> Denominations = new List<string>();
            int count = 0;
            for(int i =0; ;i++)
            {
                Console.WriteLine("Enter a blank or space to exit or enter Month to add.");
                string temp = Console.ReadLine();
                if (temp == "" || temp == " ")
                {
                    break;
                }
                else
                {
                    Months[i] = temp;
                }
                Console.WriteLine("Enter Reason.");
                Reasons[i] = Console.ReadLine();
                Console.WriteLine("Enter Value.");
                Values[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Denominations.");
                Denominations[i] = Console.ReadLine();
                count++;
            }
            for(int j = 0;j <= count; j++)
            {

            }
            Console.ReadKey();
        }
        static void Matches()
        {
            int count = 21;
            Console.WriteLine("There are 21 matches. Pick 1, 2 or 3 matches each round and whomsoever picks the last match loses.\n");
            while (true)
            {
                Console.WriteLine($"Current Count is {count}. \nPick 1, 2 or 3 matches: ");
                try
                    {
                    int picked_matches = Convert.ToInt32(Console.ReadLine());
                    if (picked_matches > 3 || picked_matches < 1)
                    {
                        Console.WriteLine("Please enter a number between 1 and 3.");
                        continue;
                    }
                    count -= picked_matches;
                    if (picked_matches == 1)
                    {
                        Console.WriteLine("You picked 1 match.");
                    }
                    else
                    {
                        Console.WriteLine($"You picked {picked_matches} matches.");
                    }
                    if (count > 1)
                    {
                        count = PickMatches(count);
                    }
                    else if (count == 1)
                    {
                        Console.WriteLine("You Won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You Lost!");
                        break;
                    }
                }
                catch (System.InvalidCastException)
                {
                    Console.WriteLine("Enter a whole number between 1 and 3.");
                    continue;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Enter a whole number between 1 and 3.");
                    continue;
                }
            }           
                Console.ReadKey();

        }
        static int PickMatches(int currentCount)
        {
            if(currentCount==4 || currentCount ==8 || currentCount == 12 || currentCount == 16 || currentCount == 20)
            {
                currentCount -= 3;
                Console.WriteLine($"Computer picked 3 matches! New Count is {currentCount}");
            }
            else if (currentCount == 3 || currentCount == 7 || currentCount == 11 || currentCount == 15 || currentCount == 19)
            {
                currentCount -= 2;
                Console.WriteLine($"Computer picked 2 matches! New Count is {currentCount}");
            }
            else if (currentCount == 2 || currentCount == 6 || currentCount == 10 || currentCount == 14 || currentCount == 18)
            {
                currentCount -= 1;
                Console.WriteLine($"Computer picked 1 match! New Count is {currentCount}");
            }
            return currentCount;
        }
    }
}