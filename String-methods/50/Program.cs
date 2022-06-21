using System;


namespace _50StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //String methods ---  Contains();
            // Program that searches for the word "air" in the sentence the user is input through :

            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();

            bool result = sentence.Contains("air");

            Console.WriteLine(result);

            // --------- or ---------- 

            Console.WriteLine("Please enter a sentence");
            string sentence2 = Console.ReadLine();
            if (sentence2.Contains("air"))
            {
                Console.WriteLine("Using the word 'air' in a sentence");
            }
            else
            {
                Console.WriteLine("No air word!");
            }


            //String methods --- Compare();

            // Program that compares two textual expressions entered by the user and shows if a match is found :

            Console.WriteLine("Enter first word");
            string word = Console.ReadLine();

            Console.WriteLine("Enter second word");
            string word2 = Console.ReadLine();

            int result2 = string.Compare(word, word2);

            if (result2 == 0)
            {
                Console.WriteLine("Words are match");
            }
            else
            {
                Console.WriteLine("Words aren't match");
            }

            Console.WriteLine(result2);

            //String methods --- IndexOf();

            // Write a program that searches for the character entered by the user in a sentence expression.

            Console.WriteLine("Please enter a sentence");
            string sentence3 = Console.ReadLine();

            Console.WriteLine("Please enter a character");
            char character = Convert.ToChar(Console.ReadLine());

            int whereIsIt = sentence3.IndexOf(character);

            Console.WriteLine(whereIsIt);


            // String methods --- Concat();

            //  Write a program that displays the name, surname, age information received from the user in the form of "my name is .... my surname ..... and my age is .....


            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            string surName = Console.ReadLine();

            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();

            string message = string.Concat("My name is ", name, " my surname is ", surName, " and my age is ", age);
            Console.WriteLine(message);


            // String methods --- PadLeft();

            // Write a program that displays only the last 4 digits of the entered credit card number and replaces the other digits with a "*" sign.

            Console.WriteLine("Please enter your credit card number last 4 digits");
            string cardNumber = Console.ReadLine();
            string dontShow = cardNumber.PadLeft(16, '*');
            Console.WriteLine("Your card number " + dontShow);


            // String methods --- Split();

            // Write a program that displays all the words of an entered sentence separately on the screen.


            Console.WriteLine("Please enter a sentence");
            string sentence4 = Console.ReadLine();

            string[] words = sentence4.Split(" ");

            foreach (string item in words)
            {
                Console.WriteLine(item);
            }

            // String methods --- ToUpper(), ToLower  

            // Write a program that prints an entered word separately as uppercase and lowercase letters.

            Console.WriteLine("Please enter a word");
            string word6 = Console.ReadLine();

            word6 = word6.ToLower();
            Console.WriteLine("All word is lowercase ");

            word6 = word6.ToUpper();
            Console.WriteLine("All word is uppercase");


            // String methods --- Format()

            // Write a program that displays the number entered by the user as the "currency" value on the screen.

            Console.WriteLine("Please enter a number");
            string number =(Console.ReadLine());

            string money = string.Format("{0:C2}" , number);
            Console.WriteLine("Your currency is : "+ money);

           




            Console.ReadLine();
        }
    }
}
