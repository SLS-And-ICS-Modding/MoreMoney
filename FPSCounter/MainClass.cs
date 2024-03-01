using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FPSCounter
{
    public class MainClass:MelonMod
    {
        float deltaTime = 0.0f;
        float updateInterval = 1.0f;
        float timer = 0.0f;
        public override void OnApplicationStart()
        {
            
        }
        public override void OnUpdate()
        {
            
        }
        public override void OnGUI()
        {
            float fps = 1.0f / deltaTime;
            GUILayout.Label($"FPS: {Mathf.Round(fps)}");
            timer += Time.deltaTime;
            if (timer > updateInterval)
            {
                deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
                timer = 0.0f;
            }
        }

    }
}
