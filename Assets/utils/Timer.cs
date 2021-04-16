using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils{
    public class Timer : MonoBehaviour
    {
        static private float previousTime;
        public static bool every(float time){
            if(Time.time - previousTime > time){
                previousTime = Time.time;
                return true;
            }else{
                return false;
            }

        }


    }

    
}
