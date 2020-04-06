using System;
using System.Collections.Generic;

namespace Library
{
    public class World
    {
        int lenght;
        int width;

        public int Lenght { get => lenght;}
        public int Width { get => width;}

        public List<Creature> creatures;
        public List<Object> objects;


        void fight(Creature attacker,Creature defender)
        {
            if (defender.defend(attacker.GetATK()))
            {
                //remove defender from map cause its dead
                creatures.Remove(defender);
            }
        }

    }
}
