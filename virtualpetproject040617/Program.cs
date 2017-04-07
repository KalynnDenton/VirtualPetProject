using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualpetproject040617
{
    class Program
    {
        static Pet myPet = new Pet();
        static bool quit = false;
        static bool isDead = false;


        static void GetPetStatus()
        {
            Console.WriteLine("name: " + myPet.petName);
            Console.WriteLine("hunger: " + myPet.petHunger);
            Console.WriteLine("boredom: " + myPet.petBoredom);
            Console.WriteLine("dirty: " + myPet.petDirty);
            Console.WriteLine("exhaustion: " + myPet.petEnergy);
        }


        static void Quit()
        {
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Please press enter to exit!");
            Console.ReadKey();
        }

        static string[] options = { "1. get pet age.", "2. feed", "3. play with", "4. clean up", "5. put to bed", "6. Punish", "7. Quit" };


        static void Main(string[] args)
        {
            string userInput = string.Empty;


            Console.WriteLine("Virtual Pet");

            Console.WriteLine("Please name your pet!");

            myPet.petName = Console.ReadLine();


            while(quit == false && isDead == false)
            {


                for (int i = 1; i < (i + 2); i++)
                {

                    GetPetStatus();

                    Console.WriteLine("----------------------------------");

                    foreach (string option in options)
                    {
                        Console.WriteLine(option);
                    }

                    Console.WriteLine("--------------------------------");

                    Console.WriteLine("Please choose a option");

                    userInput = Console.ReadLine();
                    Console.Clear();

                    switch (userInput)
                    {

                        case "1":
                            Console.WriteLine("Life: " + myPet.PetStage);
                            break;
                        case "2":
                            if (myPet.petHunger > 80)
                            {
                                Console.WriteLine("They don't look hungry...");
                            }
                            else
                            {
                                myPet.Feed();
                            }

                            break;
                        case "3":
                            if (myPet.petBoredom <= 20)
                            {
                                Console.WriteLine("You throw a ball to " + myPet.petName + " it rolls right by them.\nThey look confused.");
                            }
                            else
                            {
                                myPet.Play();
                            }
                            break;
                        case "4":
                            if (myPet.petDirty <= 0)
                            {
                                Console.WriteLine("You can't clean what isn't there!!");
                            }
                            else
                            {
                                myPet.Clean();
                            }
                            break;
                        case "5":
                            if (myPet.petEnergy >= 80)
                            {
                                Console.WriteLine("They really aren't that tired!");
                            }
                            else
                            {
                                myPet.ToBed();
                            }

                            break;
                        case "6":
                            myPet.Punish();
                            break;
                        case "7":
                            Program.Quit();
                            quit = true;
                            break;
                        default:
                            Console.WriteLine("Please choose a valid response!");
                            break;

                    }


                    if (quit == true)
                    {
                        break;
                    }

                    if (myPet.PetStage == 0)

                    {
                        Console.WriteLine(myPet.petName + " has died");
                        isDead = true;
                    }

                    if (isDead == true)
                    {
                        break;
                    }

                    }
                

                    }
                }

        }
    }

