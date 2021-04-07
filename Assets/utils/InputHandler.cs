using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils{
    public class InputHandler : MonoBehaviour
    {
        public static List<bind> actions = new List<bind>(); // таблица только с классом bind

        /*
            List - почти как таблица в lua, которая может хранить в себе обьекты одного и того же класса 
        */
        public static void bind(KeyCode key,string actionName){ // при вызове функции bind()
            //создается обьект класса bind.
            bind action = new bind(key,actionName);
            // добавляется к таблице, как и в lua: table.insert
            actions.Add(action);
        }

        // Update is called once per frame
        public static void Update()
        {
            actions.ForEach(delegate(bind action){
            /*
                для каждого в таблице, где каждый элемннт должен рассматриваться отдельно
                delegate(bind action) это обьект класса bind,т.к  
                в таблице actions содержатся только элементы класса bind
            */
                Debug.Log(action.actionName);
            });
        }
    }

    public class bind{ // класс с обьектом bind  который требует key и actionName
        public KeyCode key; // все переменные 
        public string actionName;
        public bind(KeyCode key,string actionName){ // конструктор с созданием класса
            this.key = key;
            this.actionName = actionName;
        }
    }

    public class pressed{
        public string action;

    }
}
