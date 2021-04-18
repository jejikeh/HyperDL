using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils{
    public class Timer : MonoBehaviour
    {
        public static List<timer> timers = new List<timer>(); // лист со всеми значит обьектами которые имеют таймер
        
        // ебать как это работает я не ебу
        public static void bindTimer(string name,float previousTime){ // создание так скажем отдельных обьектов таймер
            timer action = new timer(name,previousTime);
            timers.Add(action);
        }
        public static bool every(float time,string name){ 
            /*

                здесь обнавляется время для каждого таймера отдельно,
                и сделано это для того чтобы иметь возможность обнавлять таймеры
                независимо от других таймеров

            */
            bool doit = false;
            timers.ForEach(delegate(timer action){
                if(name == action.name){
                    if(Time.time - action.previousTime > time){
                        action.previousTime = Time.time;
                        doit = true;
                    }else{
                        doit = false;
                    }
                }
            });
            return doit;
        }
        /*public static void resetTime(){
            previousTime = Time.deltaTime;
            Debug.Log(previousTime);
            
        }*/
    }
    public class timer{// конструктор таймера который должен иметь нальный отсчет времени, имя и вот
        public string name;
        public float previousTime;
        public timer(string name,float previousTime){
            this.name = name;
            this.previousTime = previousTime;
        }
    }    
}
