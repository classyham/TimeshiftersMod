using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeshiftersMod.Components;
using UnityEngine;

namespace TimeshiftersMod
{
    public class Entry
    {
        public static GameObject o;

        public static void Main()
        {
            //initialize Gameobject
            Entry.o = new GameObject();
            Entry.o.AddComponent<RenderingTweaks>();

            //Make sure the object we create doesn't get destroyed between scene transitions. 
            UnityEngine.Object.DontDestroyOnLoad(Entry.o);
        }
    }
}
