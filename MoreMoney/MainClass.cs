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
        float oldmoney = 0;
        string texttoshow = "";
        int maxframes = 3000;
        int renderedframes = 0;
        public override void OnApplicationStart()
        {
            oldmoney = PlayerPrefs.GetFloat("money");
        }
        public override void OnUpdate()
        {
            if(PlayerPrefs.GetFloat("money") != oldmoney)
            {
                float orginalval = PlayerPrefs.GetFloat("money") - oldmoney;
                float multipledvalue = orginalval * 2;
                texttoshow = ($"you've earned {multipledvalue} after MoreMoney recalc");
                renderedframes = 0;
                float newvalue = oldmoney + multipledvalue;
                oldmoney = newvalue;
                PlayerPrefs.SetFloat("money", newvalue);
            }
        }
        public override void OnGUI()
        {
            if(renderedframes <= maxframes)
            {
                GUIStyle gUIStyle = new GUIStyle();
                gUIStyle.fontSize = 18;
                gUIStyle.fontStyle = FontStyle.Bold; 
                gUIStyle.normal.textColor = Color.yellow;
                GUI.Label(new Rect(Screen.width/2-15f,0,30f,20),texttoshow,gUIStyle);
            } else
            {
                renderedframes++;
            }
        }
        
    }
    
}
