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

        public World(int lenght, int width, List<Creature> creatures, List<Object> objects)
        {
            this.lenght = lenght;
            this.width = width;
            this.creatures = creatures;



            this.objects = new List<Object>();
            ObjectFactory factory = new ObjectFactory(lenght, width);
            int objcount = (lenght * width) / 10;
            for (int i = 0; i < objcount; i++)
            {
                objects.Add(factory.GetObject());
            }
        }

        void fight(Creature attacker,Creature defender)
        {
            if (defender.defend(attacker.GetATK()))
            {
                //remove defender from map cause its dead
                creatures.Remove(defender);
            }
        }
        string movePlayer(Creature player,int x,int y)
        {
            if (x<=player.PosX+1 && x>=player.PosX-1)
            {
                if (y<=player.PosY+1 && y>=player.PosY-1)
                {//coordinate is valid
                    //TODO: maybe check if position is blocked
                    player.PosX = x;
                    player.PosY = y;
                    //check if there is an object there
                    return "moved to " + x + ", " + y;

                }
            }
            return "invalid movement";

        } 

    }
}
