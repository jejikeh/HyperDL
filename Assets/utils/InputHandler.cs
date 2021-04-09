using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils{
    public class InputHandler : MonoBehaviour
    {
        public static List<bind> actions = new List<bind>(); // таблица только с классом bind
        //public static bool pressedButton = false;

        /*
            List - почти как таблица в lua, которая может хранить в себе обьекты одного и того же класса 
        */
        public static void bind(KeyCode key,KeyCode gkey,string actionName){ // при вызове функции bind()
            //создается обьект класса bind.
            bind action = new bind(key,gkey,actionName);
            // добавляется к таблице, как и в lua: table.insert
            actions.Add(action);
        }

        public static bool pressed(string actionName){
            bool pressedButton = false;
            actions.ForEach(delegate(bind action){
                if(action.actionName == actionName){
                    if(Input.GetKeyDown(action.key) || Input.GetKeyDown(action.gkey)){
                        pressedButton = true;
                        //return pressedButton;
                    }else{
                        pressedButton = false;
                    }
                }
            });
            return pressedButton;
        }

        public static bool down(string actionName){
            bool pressedButton = false;
            actions.ForEach(delegate(bind action){
                if(action.actionName == actionName){
                    if(Input.GetKey(action.key) || Input.GetKey(action.gkey)){
                        pressedButton = true;
                        //return pressedButton;
                    }else{
                        pressedButton = false;
                    }
                }
            });
            return pressedButton;
        }

        // Update is called once per frame
        public static void Update()
        {
            /*
            actions.ForEach(delegate(bind action){
            if(Input.GetKeyDown(action.key)){
                return;
            }*/
        }
    }

    public class bind{ // класс с обьектом bind  который требует key и actionName
        public KeyCode key; // все переменные 
        public KeyCode gkey;
        public string actionName;
        public bind(KeyCode key,KeyCode gkey,string actionName){ // конструктор с созданием класса
            this.key = key;
            this.gkey = gkey;
            this.actionName = actionName;
        }
    }
}
