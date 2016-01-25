using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project_1___Fortune_Teller
    {
        class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    string quit_res = "Type \"Quit\" or \"Restart\" at any time.";
                    Console.Clear();
                    Console.WriteLine("\a***********  Welcome, Traveler!  ************ \n\nCome along, Madame Jhade shall tell you your fortune! \n\nHIT ENTER.");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Type \"Quit\" or \"Restart\" at any time.");
                    Console.WriteLine("\n\nWhat is your FIRST name, my friend?");
                    string firstName = Console.ReadLine();
                    if (firstName.ToUpper() == "QUIT")
                    {
                        return;
                    }
                    else if (firstName.ToUpper() == "RESTART")
                    {
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                    }
                    Console.WriteLine(quit_res);
                    Console.WriteLine("\n\nNow, tell me your LAST name.");
                    string lastName = Console.ReadLine();
                    if (lastName.ToUpper() == "QUIT")
                    {
                        return;
                    }
                    else if (lastName.ToUpper() == "RESTART")
                    {
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                    }
                    Console.WriteLine(quit_res);
                    Console.WriteLine("\n\nTell me your age.");
                    string age = Console.ReadLine();
                    int ageInt;
                    bool ageNotANum = int.TryParse(age, out ageInt);
                    if (age.ToUpper() == "QUIT")
                    {
                        return;
                    }
                    else if (age.ToUpper() == "RESTART")
                    {


                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        if (ageNotANum == false)
                        {
                            ageInt = firstName.Length * lastName.Length;
                        }
                    }

                    Console.WriteLine(quit_res);
                    Console.WriteLine("\n\nThank you, my friend. \n\nNow, tell Madame Jhade, in what month were you born? \nFor the stars that witnessed your birth see all.");
                    string month = Console.ReadLine();
                    if (month.ToUpper() == "QUIT")
                    {
                        return;
                    }
                    else if (month.ToUpper() == "RESTART")
                    {
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                    }
                    Console.WriteLine(quit_res);
                    Console.WriteLine("\n\nTell me your favorite color. \n\nSELECT ONLY A COLOR IN ROYGBIV!\n\n\n(If you do not know ROYGBIV, please type \"Help\")");
                    string color = Console.ReadLine();
                    if (color.ToUpper() == "HELP")
                    {
                        Console.WriteLine("Choose from one of the following colors:\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet");
                        color = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (color.ToUpper() == "QUIT")
                    {
                        return;
                    }
                    else if (color.ToUpper() == "RESTART")
                    {
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                    }

                    Console.WriteLine(quit_res);
                    Console.WriteLine("\n\nHow many siblings do you have?");
                    string bros = Console.ReadLine();
                    int brosInt;
                    bool notAnumb = int.TryParse(bros, out brosInt);

                    if (bros.ToUpper() == "QUIT")
                    {
                        return;
                    }
                    else if (bros.ToUpper() == "RESTART")
                    {
                        continue;
                    }
                    else
                    {
                        if (notAnumb == false)
                        {
                            brosInt = firstName.Length;
                            Console.Clear();
                        }
                    }
                    //Part 2:
                    Console.WriteLine(quit_res);
                    Console.WriteLine("\n\nVery good, my friend. Hit ENTER to see your fortune!");
                    Console.ReadKey();
                    Console.Clear();
                    int retireChoiceA = (firstName.Length * 3);
                    int retireChoiceB = (lastName.Length * 2);

                    int retireAge;
                    if (ageInt % 2 == 0)
                    {
                        retireAge = retireChoiceA;
                    }
                    else
                    {
                        retireAge = retireChoiceB;
                    }

                    string upperFirst = firstName.ToUpper();
                    string upperLast = lastName.ToUpper();

                    Console.WriteLine("\n********************************************\n" + upperFirst + " " + upperLast + ", your fortune is as follows:");
                    Console.WriteLine("\n\nYou shall retire in " + retireAge + " years!");

                    string[] placesArray = { "Kyoto, Japan", "Cancun, Mexico", "Toronto, Canada", "Soviet Russia", "North Korea" };

                    string place;

                    switch (brosInt)
                    {
                        case 0:
                            place = placesArray[0];
                            break;
                        case 1:
                            place = placesArray[1];
                            break;
                        case 2:
                            place = placesArray[2];
                            break;
                        case 3:
                            place = placesArray[3];
                            break;
                        default:
                            place = placesArray[4];
                            break;
                    }

                    Console.WriteLine("\nYou shall have a glorious home in " + place + "!");

                    string colorCar = "a black 2011 Ford Fiesta";
                    switch (color.ToUpper())
                    {
                        case "RED":
                            colorCar = "a red 2013 Nissan Juke";
                            break;
                        case "ORANGE":
                            colorCar = "an orange 1995 Honda Accord";
                            break;
                        case "YELLOW":
                            colorCar = "a yellow 1968 VW Bug";
                            break;
                        case "GREEN":
                            colorCar = "a green 2015 Dodge Charger";
                            break;
                        case "BLUE":
                            colorCar = "a blue 2009 Honda Civic";
                            break;
                        case "INDIGO":
                            colorCar = "an indigo 2015 Lamborghini Murcielago";
                            break;
                        case "VIOLET":
                            colorCar = "a 2014 Chevy Spark";
                            break;
                    }

                    Console.WriteLine("\nYou shall drive " + colorCar + "!");

                    string fullname = firstName + lastName;

                    int bankAmount1;
                    int bankAmount2;
                    int bankAmount3;
                    int bankAmount4 = fullname.Length * 28000;

                    switch (firstName.Length)
                    {
                        case 1:
                        case 2:
                        case 3:
                            bankAmount1 = (firstName.Length * 95000);
                            break;
                        case 4:
                        case 5:
                        case 6:
                            bankAmount1 = (firstName.Length * 75000);
                            break;
                        case 7:
                        case 8:
                        case 9:
                            bankAmount1 = (firstName.Length * 49000);
                            break;
                        default:
                            bankAmount1 = (firstName.Length * 38000);
                            break;
                    }

                    switch (lastName.Length)
                    {
                        case 1:
                        case 2:
                        case 3:
                            bankAmount2 = (lastName.Length * 910000);
                            break;
                        case 4:
                        case 5:
                        case 6:
                            bankAmount2 = (lastName.Length * 68000);
                            break;
                        case 7:
                        case 8:
                        case 9:
                            bankAmount2 = (lastName.Length * 40000);
                            break;
                        default:
                            bankAmount2 = (lastName.Length * 38000);
                            break;
                    }

                    switch (month.Length)
                    {
                        case 1:
                        case 2:
                        case 3:
                            bankAmount3 = (month.Length * 100000);
                            break;
                        case 4:
                        case 5:
                        case 6:
                            bankAmount3 = (month.Length * 75000);
                            break;
                        case 7:
                        case 8:
                        case 9:
                            bankAmount3 = (month.Length * 49000);
                            break;
                        default:
                            bankAmount3 = (lastName.Length * 38000);
                            break;
                    }

                    string fullUp = fullname.ToUpper();
                    string monthUp = month.ToUpper();

                    int bankAmountFortune;
                    if (fullUp.IndexOf(monthUp[0]) != -1)
                    {
                        bankAmountFortune = bankAmount1;
                    }
                    else if (fullUp.IndexOf(monthUp[1]) != -1)
                    {
                        bankAmountFortune = bankAmount2;
                    }
                    else if (fullUp.IndexOf(monthUp[2]) != -1)
                    {
                        bankAmountFortune = bankAmount3;
                    }
                    else
                    {
                        bankAmountFortune = bankAmount4;
                    }

                    Console.WriteLine("\nAnd you shall have $" + bankAmountFortune + " in the bank!");

                    string fNameEnd = firstName.Substring(1, firstName.Length - 1);
                    string lNameEnd = lastName.Substring(1, lastName.Length - 1);
                    string fn = Convert.ToString(firstName[0]);
                    string ln = Convert.ToString(lastName[0]);

                    Console.WriteLine("\n\n\nTo sum up:\n" + fn.ToUpper() + fNameEnd.ToLower() + " " + ln.ToUpper() + lNameEnd.ToLower() + " will retire in " + retireAge + " years, with $" + bankAmountFortune + " in the bank, a vacation home in " + place + ", and " + colorCar + ".");

                    Console.WriteLine("\n\nShall I tell your fortune again? \nType \"Yes\" or \"No\"");
                    string userAgainChoice = Console.ReadLine();
                    if (userAgainChoice.Equals("YES", StringComparison.CurrentCultureIgnoreCase))
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
