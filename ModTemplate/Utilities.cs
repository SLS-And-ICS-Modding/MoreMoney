using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace ModTemplate
{
    /*
     * 
     * basically class containing basic
     * utilites, remember most of variables like IsInGame
     * should work in most Chesscake dev games but it may
     * not work in some games
     */

    /*
     * if you want to mod any other game than Internet Cafe Simulator
     * edit Properties->AssemblyInfo.cs
     */
    public static class Utilities
    {
        public static bool IsInGame => GameObject.FindGameObjectsWithTag("Player").Length <= 0;
        public static GameObject localplayer => GameObject.FindGameObjectWithTag("Player");
    }
}
