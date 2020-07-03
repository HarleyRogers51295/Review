using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1UI
{
    class Program
    {
        static void Main(string[] args)//This is where you put the code you want to exicute.
        {
            /*********List the basics************/

            //Every Line of code ends with a;
            Console.WriteLine("Hello World");//Console.WriteLine(); prints whatever is in the () to the console.

            Console.ReadLine();//This is for user input in the console.

            //Draw a shape
            Console.WriteLine("make a shape");
            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");
            //C# operatis in an order. The order does matter. 
            Console.ReadLine();
            Console.WriteLine();

            /**************Variables***************/

            Console.WriteLine("Example of declaring a variable and using it");
            string characterName = "John";//two different ways to declare a variable.
            int characterAge;
            characterAge = 25;
            characterAge = 26; //You can change variables value. But not the Type.
            Console.WriteLine($"ther once was a dude names { characterName}. They are {characterAge} years old.");
            //variables help us keep up with data.
            Console.ReadLine();
            Console.WriteLine();

            /*************Data types******************/

            string string1 = "string"; //used for plain text.
            char char1 = 'A'; //used for only one character. Uses ' ' instead of " ".
            int int1 = 20; //used for numbers WITHOUT decimals. this can be whole, or negative. 20 or -20.
            decimal dec1 = 1.2464669m;//Most acurate with decimals. If working with money use this. Needs the m at the end.
            double double1 = 1.12565;// less acurete but used most often.
            float float1 = 1.254f;//least acurate. needs the f at the end.
            bool bool1 = true;//booleans are for true or false.
            bool bool2 = false;
            // you do not have to store information inside variables.

            /************Working with Strings***************/

            Console.WriteLine("Manipulating strings");
            string phrase = "Randome \nsentance.";//The \n drops a line. So these two workds will print on different lines. 
            Console.WriteLine($"The length is: {phrase.Length}");//.Length shows the amount of characters is in the string
            Console.WriteLine(phrase.ToUpper());//This turns all the srring to upper case characters. You need the . between. 
            Console.WriteLine(phrase.ToLower());//converts to lower case
            Console.WriteLine($"Does this contain sentance? {phrase.Contains("sentance")}");//sees if a "sentance" is in the string.
            Console.WriteLine($"The first character is: {phrase[0]}.");//prints out the character at the index requested.
            //Index starts at 0!!!
            Console.WriteLine($"What is the index of: {phrase.IndexOf("sentance")}"); //Find the index of. -1 means it is not in the string.
            Console.WriteLine($"Specific indexes: {phrase.Substring(8, 3)}");//pulling specific indexes. (9, is the index you start on. 3 is the amount of indexes pulling)
            Console.ReadLine();
            Console.WriteLine();

            /*********************Using Numbers****************/
            
            Console.WriteLine("Using numbers");//Pretty much basic math here.
            Console.WriteLine(5 + 5);
            Console.WriteLine(5 - 5);
            Console.WriteLine(5 * 5);
            Console.WriteLine(5 / 5);
            Console.WriteLine(5 % 5); //leves the remainder. Good to find even or odd numbers.
            Console.WriteLine(5.21 + 8); //If it has a deciaml it will stay at a double. if theyre both int, they will be int.
            Console.WriteLine();
            Console.WriteLine("numbers in a var");
            int int2 = 6;
            Console.WriteLine(int2++);//++ increments it by 1.
            //Math methods!
            Console.WriteLine("Math Methods!");
            Console.WriteLine($"Absolute Value of -40: {Math.Abs(-40)}");//absolute value. returns 40.
            Console.WriteLine($"3 raised to the 2nd power: {Math.Pow(3, 2)}");//first number taken to the second. 3 raised to the second power.
            Console.WriteLine($"The square root of 36: {Math.Sqrt(36)}");//Sqyuare root. Should get back 6.
            Console.WriteLine($"The biggest number out of 42, and 90: {Math.Max(42, 90)}");//Gives us the biggest number.
            Console.WriteLine($"the lowest number: {Math.Min(42, 90)}");//gives us the smallest amont.
            Console.WriteLine($"rounding 4.3: {Math.Round(4.3)}");//rounds it to the closest whole num,ber.
            //There are a lot more!!
            Console.ReadLine();
            Console.WriteLine();

            /************Getting User Input Basics***********/

            Console.WriteLine("Getting user input!");
            Console.Write("Put you're input here:");
            var input1 = Console.ReadLine();//this stores the user input.
            //using var here to give the user more flexibility. Var is best practivce.
            Console.WriteLine($"Hello! Here is your input: {input1}");
            //You can do this with multiple different inputs.
            Console.ReadLine();
            Console.WriteLine();

            /***************Basic Calculator functions***************/

            //Convert a string into a number.
            int num = Convert.ToInt32("45");//This has to have a number in the string.
            Console.WriteLine(num + 6); //This shows it being changed to a number.
            Console.WriteLine();
            //OR!
            Console.WriteLine("Write your number");//These are the tqo ways to do it!
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num + num1);//Both work!
            Console.WriteLine();

            Console.WriteLine("Write a decimal number!");//It might be best with a calculator application to use doubles or better, deciamls. 
            double double6 = double.Parse(Console.ReadLine());
            double double2 = Convert.ToDouble(Console.ReadLine());//You can do it either way!
            Console.ReadLine();
            Console.WriteLine();

            /*******************Building Mad Libs Game*****************/

            Console.WriteLine("Mad Libs Game!");
            Console.WriteLine();
            Console.Write("Enter word that rhymes with red:");
            string randomWord1 = Console.ReadLine();
            Console.Write("Enter a object:");
            string randomWord2 = Console.ReadLine();
            Console.Write("Enter a celebrities name:");
            string randomWord3 = Console.ReadLine();
            Console.Write("Enter a preposition:");
            string randomWord4 = Console.ReadLine();
            Console.Write("Enter a plural noun:");
            string randomWord5 = Console.ReadLine();

            Console.WriteLine($"Roses are {randomWord1}");
            Console.WriteLine($"Violets are {randomWord2}");
            Console.WriteLine($"{randomWord3} is dead");
            Console.WriteLine($"{randomWord4} about {randomWord5}!");
            Console.ReadLine();
            Console.WriteLine();

            /*******************ARRAYS****************************/

            string[] array = new string[10]; // this makes an empty array with 10 indexes.
            int[] array2 = { 1, 2, 3, 4, 5 }; //This is anpther way to call an array.
            //accessina arrays values!
            Console.WriteLine(array2[3]);//this will print out 1. You put the name, then the index you want.
            array2[3] = 9000000;//you can update the indexes in the arrays.
            Console.WriteLine(array2[3]);
            //We can populate the other array.
            array[0] = "bob";
            array[1] = "george";
            Console.ReadLine();
            Console.WriteLine();

            /*********************METHODS******************/ // Methods 1

            Console.WriteLine("enter your name!");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            SayHi(name, age); //This calls the method! You have to call it for it to run!
            Console.ReadLine();
            Console.WriteLine();

            /*************RETURN STATEMENTS****************/ //Method 2

            Console.WriteLine(Cube(5)); //With a return form of method, we have to do this to see the result.
            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber);//There is multiple ways to do this. 
            Console.ReadLine();
            Console.WriteLine();

            /***************IF STATEMENTS*******************/

            Console.WriteLine("If Statements!");
            bool isMale = true;
            bool isTall = true;
            if (isMale && isTall) //With this you dont even have to put the == ... it is already true!
            {
                Console.WriteLine("You are a tall male!"); //if both ture!
            }
            else if (isMale || isTall)
            {
                Console.WriteLine("you are either a male or very tall...");// if one is true!
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short dude");
            }
            else
            {
                Console.WriteLine("You are a short female!");// if neither is true
            }
            Console.ReadLine();

            /*******************More on If Statements!****************/  //Method 3
            Console.WriteLine("More on if statements");
            Console.WriteLine("Write your three numeber and see which one is the biggest!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"The larger number is:{GetMax(a, b, c)}");
            Console.ReadLine();
            Console.WriteLine();

            /*****************MORE ADVANCED CALCULATOR**********************/

            Console.Write("Enter a number: ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator: ");
            string f = Console.ReadLine();

            Console.Write("Enter a number: ");
            double e = Convert.ToDouble(Console.ReadLine());

            if (f == "+")
            {
                Console.WriteLine(d + e);
            }
            else if (f == "-")
            {
                Console.WriteLine(d - e);
            }
            else if (f == "/")
            {
                Console.WriteLine(d * e);
            }
            else if (f == "*")
            {
                Console.WriteLine(d / e);
            }
            else
            {
                Console.WriteLine("Error: Invalid Operator!");
            }
            Console.ReadLine();
            Console.WriteLine();

            /*****************SWITCH STATEMENTS****************/ //Method 4

            Console.WriteLine("Switch Statements!");
            Console.WriteLine("pick 1-6 to choose your day!");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine(DayName(g));
            Console.ReadLine();
            Console.WriteLine();

            /********************WHILE LOOP********************/

            Console.WriteLine("While Loops!");
            int h = 0;
            while (h < 10)
            {
                Console.WriteLine(h);
                h++; //This runs until it reaches 10! You need the increments so it wont be an infinite loop!
            }
            Console.WriteLine("Finished!");
            Console.ReadLine();
            Console.WriteLine();

            /*****************DO - While Loop********************/

            Console.WriteLine("Do While Loop");
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);
            Console.WriteLine("finished!");
            Console.ReadLine();
            Console.WriteLine();

            /*****************Guessing Game!********************/

            Console.WriteLine("Guessing Game!");

            var secretWord = "poop";
            var guess = " ";
            int guessCount = 0;
            bool outOfGuesses = false;
            guessCount++;
            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < 4)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    outOfGuesses = true;
                    Console.WriteLine("Out of guesses.");
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }

            Console.ReadLine();
            Console.WriteLine();

            /*****************FOR LOOP********************/

            Console.WriteLine("For Loops!");
            for (int i = 0; i <= 10; i++)//this is doing the exact same thing as the while loop above in the first example.
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("finished!");
            Console.WriteLine();

            Console.WriteLine("For loop with Array");
            int[] array3 = { 52, 4, 64, 15, 65, 48, 654, 12, 2 };
            for (int k = 0; k < array3.Length; k++)
            {
                Console.WriteLine(array3[k]);
            }
            Console.ReadLine();
            Console.WriteLine();

            /***************Exponent Method***************************/ //Method 5

            Console.WriteLine("Exponent Method!");
            Console.Write("give me the nimber you want to exponent:");
            int l = int.Parse(Console.ReadLine());
            Console.Write("What power do you want to go to?");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(GetPow(l, m));
            Console.ReadLine();
            Console.WriteLine();

            /********************2d Array*********************/

            //To do a 2D array you need to put the , in the [].
            int[,] array4 =
            {
                {3, 4, 5, 6}, //index 0 
                {2, 5, 6, 7 }, //index 1
                {1, 6, 9, 7 }, //index 2
                {4, 7, 8, 9 } //index 3
               //0, 1, 2, 3  These are the indexes...
            };
            Console.WriteLine(array4[3, 2]); //(3) is the firsr index. so it would be index 3. (2) is the second index. 
            // so [3, 2] pulls 8.

            int[,] array5 = new int[2, 3]; // this is two elements with 3 elements in it. Example above is [3, 3]...I think.
            Console.ReadLine();
            Console.WriteLine();

            /*********************Exception handeling*******************************/

            Console.WriteLine("Here we have a TryCatch! It catches errors instead of crashing the system!");
            Console.WriteLine("Enter in 0");
            int n = int.Parse(Console.ReadLine());//the try catch catches erros so it doesnt crash your program!
            try
            {
                Console.WriteLine(5 / n);
            }
            catch (Exception z) //If you want you can do specific ones!
            {
                Console.WriteLine($"Error: {z.Message}");
            }
            //catch (FormatException e) { }
            //catch (DivideByZeroException e) { } these are usefull to make special notes for each error!
            Console.ReadLine();//this makes programs more durrible.
            Console.WriteLine();

            /***********************Classes & Objects***************************/

            Console.WriteLine("Here we make our books");
            //see class Book for class examples.
            Book book1 = new Book("", "", 0, "");//this is an instance of the class. An object.
            book1.Title = "Harry Potter";
            book1.Author = "J.K.Rowling";
            book1.Pages = 400;

            Book book2 = new Book("", "", 0, " ");//this is an instance of the class. An object.
            book2.Title = "Lord of the Rings";
            book2.Author = "Tolkein";
            book2.Pages = 700;
            //both of these are seperate books!

            Console.WriteLine(book1.Title);//here we call the objects.
            Console.WriteLine(book2.Title);

            Console.ReadLine();
            Console.WriteLine();

            /***************************Constructors******************/

            Console.WriteLine("Here is a better way to make a book/object. \nWe use the constructor!");
            Book book3 = new Book("Manslaughter", "Rebekah Rogers", 1520, "PG-13");
            Console.WriteLine(book3.Title);
            Book book4 = new Book("laughter", "Mr.Rogers", 120, "G");
            Console.WriteLine(book4.Title);
            Console.ReadLine();

            Console.WriteLine();
            /***********************Object Methods***********************/ //Class Method 1

            Console.WriteLine("Object methods!"); //both objects can use the same method
            Console.WriteLine(book3.BookHonors());
            Console.WriteLine(book4.BookHonors());
            Console.ReadLine();
            Console.WriteLine();

            /*******************Getters & Setter************************/

            Console.WriteLine("Getters & Setters");
            //using this to keep data secure!
            Console.WriteLine(book4.Rating);
            Console.WriteLine();

            /*******************Static Attributes in the Class***************/

            Console.WriteLine("Static Attributes");
            Console.WriteLine(Book.BooksWriten); //This will count how many books are written.
            Console.WriteLine(book3.GetBookCount()); //you can also use a methed to get the number.
            Console.WriteLine();

            /*****************Static Methods and Classes**********************/

            Console.WriteLine("Static Methods");
            Book.SayHello("Harley");
            Console.WriteLine();

            /*****************Inheritance*****************/

            //Look to Chapter for inheritance.

            Chapter chap1 = new Chapter("The Dark Mirror!", "Harry Potter", "JK Row", 23);
           // the sub class has the extra parameter.the Book class does not have this. but Chapters has all the Book classes perameters.
           Book book6 = new Book("Harry Potter", "JK Row", 23, "PG");
        book6.SayHello1("Harley");
            chap1.SayHello1("Harley"); //these will output differetn things wiht the virtual and override keywords in the methods.


        }
    /*********************Methods*********************/ // Methods 1

    public static void SayHi(string name, int age) //Here we define the method. Void means it doesnt 'return' a value. 
    {//You can have many different things passed into a method!
        Console.WriteLine($"Hello {name}! You are {age} years old!");//name methods on what it does.
    }

    /*************RETURN STATEMENTS****************/ //Method 2

    public static int Cube(int num)
    {
        int result = num * num * num;
        return result;//this returns the value to the method.
    }

    /****************More On IF STATEMENT*********************/ //Method 3

    public static int GetMax(int num1, int num2, int num3)
    {
        int result = 0;//result needs a value. set it to 0.
        if (num1 >= num2 && num1 >= num3)//this checks to see if num1 is biggest
        {
            result = num1;

        }
        else if (num2 >= num1 && num2 >= num3)//this checks to see if nume2 is biggest
        {
            result = num2;
        }
        else//if both those fail num3 is biggest!
        {
            result = num3;
        }

        return result;
    }

    /*****************SWITCH STATEMENTS*********************/ //Method 4

    public static string DayName(int dayNum)//switch statements are more readable than the if statements.
    {
        string dayName;
        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saterday";
                break;
            default:
                dayName = "Invallid Input";
                break;

        }

        return dayName;

    }

    /*******************Exponent Method**********************/ //Method 5

    public static int GetPow(int baseNum, int powNum)
    {
        int result = 1;

        for (int i = 0; i < powNum; i++) //this loop makes it so baseNum is being mutiplied by itself powNum times.
        {
            result = result * baseNum;
        }

        return result;
    }

    /******************************************/


}
}
