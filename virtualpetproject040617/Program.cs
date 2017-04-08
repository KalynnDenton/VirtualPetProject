using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualpetproject040617
{
    class Program
    {
        static Pet myPet = new Pet();//Instantiated a new "pet" from the default constructor
        static bool quit = false; // The user can quit at anytime in the program. quit is false so the program can continue looping.
        static bool isDead = false;//Another way to end the program.


        static void GetPetStatus()
        {
            Console.WriteLine("name: " + myPet.petName);
            Console.WriteLine("hunger: " + myPet.petHunger);
            Console.WriteLine("boredom: " + myPet.petBoredom);
            Console.WriteLine("dirty: " + myPet.petDirty);
            Console.WriteLine("energy levels: " + myPet.petEnergy);
        } //A method made in Program class. Get's the pet's status to be used as a menu.


        static void Quit()
        {
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Please press enter to exit!");
            Console.ReadKey();
        }//If you choose to quit. This runs.

        static string[] options = { "1. get pet age.", "2. feed", "3. play with", "4. clean up", "5. put to bed", "6. Punish", "7. Quit" };
        //A array to list the available options.

        static void Main(string[] args)//Program! START!!
        {
            string userInput = string.Empty;//A variable for user input. Used for the switch statement below.


            Console.WriteLine("Virtual Pet");

            Console.WriteLine("Please name your pet!");

            myPet.petName = Console.ReadLine(); //throws petName a value to use.


            while(quit == false && isDead == false)//a while loop that only works while these two bools are false (Is the pet dead or did the user say quit?)
            {


                for (int i = 1; i < (i + 2); i++)//A for loop to keep the menu running until the pet dies or user quits.
                {

                    GetPetStatus();

                    Console.WriteLine("----------------------------------");

                    foreach (string option in options)
                    {
                        Console.WriteLine(option); //list the options
                    }

                    Console.WriteLine("--------------------------------");

                    Console.WriteLine("Please choose a option");

                    userInput = Console.ReadLine();//Throws a value into userInput.
                    Console.Clear(); // Keeps things clean.

                    switch (userInput)
                    {

                        case "1":
                            Console.WriteLine("Life: " + myPet.petAge);
                            if(myPet.petAge == 200)//The life stage feature I was so excited about. Only works at certain points in the pet's life cycle.
                            {
                                Console.WriteLine(myPet.petName + " is a baby!");
                            } if (myPet.petAge == 100) //if life is 100, the pet is a baby.
                            {
                                Console.WriteLine(myPet.petName + " is a kid!");
                            }if (myPet.petAge == 50) //if 50, an adult.
                            {
                                Console.WriteLine(myPet.petName + " is a grown up!");
                            }if(myPet.petAge == 20) //pet may die soon.
                            {
                                Console.WriteLine(myPet.petName + " is in their sunset.");
                            }

                            break;
                        case "2":
                            if (myPet.petHunger > 80)//If the pet is "full", it won't eat.
                            {
                                Console.WriteLine("They don't look hungry...");
                            } 
                            else
                            { //It will if it is.
                                myPet.Feed();
                            }

                            break;
                        case "3":
                            if (myPet.petBoredom <= 20)
                            { //If it isn't bored. It won't play.
                                Console.WriteLine("You throw a ball to " + myPet.petName + " it rolls right by them.\nThey look confused.");
                            }
                            else
                            {
                                myPet.Play();
                            }
                            break;
                        case "4":
                            if (myPet.petDirty <= 0)
                            { //If it's not dirty. You can't clean.
                                Console.WriteLine("You can't clean what isn't there!!");
                            }
                            else
                            {
                                myPet.Clean();
                            }
                            break;
                        case "5":
                            if (myPet.petEnergy >= 80)
                            {//They won't sleep if they aren't tired.
                                Console.WriteLine("They really aren't that tired!");
                            }
                            else
                            {
                                myPet.ToBed();
                            }

                            break;
                        case "6":
                            myPet.Punish();//This is mean. Don't do this. It will kill your pet.
                            break;
                        case "7":
                            Quit();//Runs quit and changes quit to true. This breaks the loop and ends the program.
                            quit = true;
                            break;
                        default:
                            Console.WriteLine("Please choose a valid response!");
                            break; //Please choose a valid response!! D:

                    }


                    if (quit == true)
                    {
                        break; //once quit is true, end the program.
                    }

                    if (myPet.petAge == 0 || myPet.petHunger <= 0) //if the pet's life goes to 0 OR the pet's hunger goes to 0. The pet dies.
                        //which ends the program.

                    {
                        Console.Clear();
                        Console.WriteLine(myPet.petName + " has died");
                        isDead = true;
                    }

                    if (isDead == true)
                    {
                        //if isDead is true. The program ends.
                        break;
                    }

                    }
                

                    }
                }

        }
    }

