﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Lumpkin_Dalton
{
    class Game
    {

        public int MaxPlayers { get;}

         public int CurrentPlayers { get; set; }
        public Game(int maxP, int currentP)
        {
        MaxPlayers = maxP;
        CurrentPlayers = currentP;
        }

        public void KickPlayer()
        {
            CurrentPlayers--;
        }
        public void CheckQueue(Queue<Player> playerQueue)
        {
            if(CurrentPlayers < MaxPlayers)
            {
                if(playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("there aint no one in da queue");
                }
            }
        }
    }
}
