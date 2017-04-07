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

        private int hunger = 80;
        private int energy = 100;
        private int dirty = 0;
        private int life = 200;
        private int bored = 0;
        public string petName = String.Empty; //I created an empty string for the pet name. It will take input from the user.

        //I'd like to figure out a way to show the pet's life cycle. When pet life = value it will be a certain life stage.
        //This can probably be done in main
        
        public Pet()
        {

        }

        public Pet(string name, int hungerCount, int tiredCount, int dirtyCount, int lifeCount, int boredCount)
        {
            this.petName = name;
            this.energy = tiredCount;
            this.dirty = dirtyCount;
            this.life = lifeCount;
            this.bored = boredCount;
        }

        public void Feed()
        {
            Console.WriteLine("You feed " + petName + " They look happy!! ");
            hunger += 15;
            energy += 10;
            life -= 10;
            dirty += 10;
            bored += 10;

        }

        public void Clean()
        {
            hunger += 0;
            energy += 0;
            life -= 10;
            dirty -= 20;
            bored += 10;
        }

        public void Play()
        {
            Console.WriteLine("You play ball with " + petName );


            hunger -= 20;
            energy -= 10;
            life -= 10;
            dirty += 10;
            bored -= 20;
        }
        public void ToBed()
        {
            Console.WriteLine("You put " + petName + " to sleep! " );


            hunger += 15;
            energy += 50;
            life -= 10;
            dirty += 10;
            bored += 10;

        }
        public void Punish()
        {
            hunger += 0;
            energy -= 20;
            life -= 50;
            dirty += 50;
            bored += 10;

            Console.WriteLine("Why would you do that?!");
            Console.WriteLine("Don't you know that stressing them out will make them age fast!!");
        }

        public void petStage()
        {
            Console.WriteLine(life);
        }

        public int petHunger
        {
            get { return this.hunger; }
            set { hunger = value; }
        }

        public int petEnergy
        {
            get { return this.energy; }
            set { energy = value; }
        }
        public int petDirty
        {
            get { return this.dirty; }
            set { dirty = value; }
        }
        public int petAge
        {
            get { return this.life; }
            set { life = value; }
        }
        public int petBoredom
        {
            get { return this.bored; }
            set { bored = value; }
        }
        public int PetStage
        {
            get { return this.life; }
            set { life = value;}
        }
    }
    }


