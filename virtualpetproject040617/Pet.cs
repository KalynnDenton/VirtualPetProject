using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualpetproject040617
{
    public class Pet
    { //To start, I'll create a public class for the object "pet"

        //These are the variables in the object "pet". 

        private int hunger = 100;
        private int energy = 100;
        private int dirty = 0;
        private int life = 200;
        private int bored = 0;
        public string petName = String.Empty; //I created an empty string for the pet name. It will take input from the user.

        //I'd like to figure out a way to show the pet's life cycle. When pet life = value it will be a certain life stage.
        
        
        public Pet() //Default constructor
        {

        }

        public Pet(string petName, int hunger, int tired, int dirty, int life, int bored)
        {
            this.petName = petName;
            this.energy = tired;
            this.dirty = dirty;
            this.life = life;
            this.bored = bored;
        } // I realized I didn't exactly need this constructor. But I decided to keep it anyways

        public void Feed() //Feeding method, this causes the stat changes for being fed.
        {
            Console.WriteLine("You feed " + petName + " They look happy!! ");
            hunger += 15;
            energy += 10;
            life -= 5;
            dirty += 10;
            bored += 10;

        }

        public void Clean() //Cleaning method
        {
            Console.WriteLine("You clean up after " + petName);
            hunger += 0;
            energy += 0;
            life -= 5;
            dirty -= 10;
            bored += 10;
        }

        public void Play()
        {
            Console.WriteLine("You play ball with " + petName );


            hunger -= 20;
            energy -= 40;
            life -= 10;
            dirty += 10;
            bored -= 20;
        }
        public void ToBed()
        {
            Console.WriteLine("You put " + petName + " to sleep! " );


            hunger -= 10;
            energy += 60;
            life -= 10;
            dirty += 10;
            bored += 10;

        }
        public void Punish()//Please do not do this. 
        {
            hunger -= 20;
            energy -= 20;
            life -= 50;
            dirty += 50;
            bored += 0;

            Console.WriteLine("Why would you do that?!");
            Console.WriteLine("Don't you know that stressing them out will make them age fast!!");
        }

       

        public int petHunger //Gets and sets the value for petHunger
        {
            get { return this.hunger; }
            set { hunger = value; }
        }

        public int petEnergy //Gets and sets the value for petEnergy
        {
            get { return this.energy; }
            set { energy = value; }
        }
        public int petDirty//Gets and sets the value for petDirty
        {
            get { return this.dirty; }
            set { dirty = value; }
        }
        public int petAge //gets and sets the petsAge... why did I do this twice?!?
        {
            get { return this.life; }
            set { life = value; }
        }
        public int petBoredom
        {
            get { return this.bored; }
            set { bored = value; }
        }
    }
    }


