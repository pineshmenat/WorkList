using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkList
{
    class Timer
    {
        public static int workTimeMinutes;  //Type 0
        public static int shortBreakTimeMinutes; //Type 1
        public static int longBreakTimeMinutes; //Type 2
        public static int longBreakInterval;    //Type 3
        public static int stopWatchTimer = 0;

        public static System.Media.SoundPlayer workTimePlayer = new System.Media.SoundPlayer("default.wav");
        public static System.Media.SoundPlayer breakTimePlayer = new System.Media.SoundPlayer("bell.wav");


    }
}
