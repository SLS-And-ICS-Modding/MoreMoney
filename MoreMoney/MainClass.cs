using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MoreMoney
{
    public class MainClass:MelonMod
    {
        
        public override void OnApplicationStart()
        {
            
        }
        public override void OnUpdate()
        {
            foreach(var civil in GameObject.FindObjectsOfType<Civil>())
            {
                if(civil.payedPrice > 0) 
                {
                    civil.payedPrice = civil.payedPrice * 2;
                }
            }
        }
        public override void OnGUI()
        {
            
        }
        
    }
    
}
