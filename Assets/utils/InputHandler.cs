using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils{
    public class InputHandler : MonoBehaviour
    {
        public static List<Bind> actions = new List<Bind>(); // таблица только с классом bind
        //public static bool pressedButton = false;

        /*
            List - почти как таблица в lua, которая может хранить в себе обьекты одного и того же класса 
        */

        public TetrisBlock _tetrisBlock;
        public static void bind(KeyCode[] key,string actionName){ // при вызове функции bind()
            //создается обьект класса bind.

            Bind action = new Bind(key,actionName);
            // добавляется к таблице, как и в lua: table.insert
            actions.Add(action);
        }

        void Start(){
            CameraControll.setCameraTarget(transform,new Vector3(0,0,-20));// !!!!----

            // Перевести в отдельный файл с настройкой игры

            KeyCode[] actionMove = new KeyCode[] {KeyCode.D,KeyCode.RightArrow};
            bind(actionMove,"Fuck");
        }

        void pressed(string actionName){
            actions.ForEach(delegate(Bind action){
                if(action.actionName == actionName){
                    for(int i=0; i < action.key.Length; i++){
                        if(Input.GetKeyDown(action.key[i])){
                            var func = action.actionName;
                            _tetrisBlock.Run();
                            //return pressedButton;
                        }
                    }
                }
            });
        }

        void Update(){
            actions.ForEach(delegate(Bind action){
                pressed(action.actionName);
            });
        }
    }

    public class Bind{ // класс с обьектом bind  который требует key и actionName
        public KeyCode[] key; // все переменные
        public string actionName;
        public Bind(KeyCode[] key,string actionName){ // конструктор с созданием класса
            this.key = key;
            this.actionName = actionName;
        }
    }


    public class Swipe{

    }
}
