using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class move : MonoBehaviour
{
    int direction =1;
    float xPosition = 0;
    bool isMoving = true;
    void Start()
    {
        Utils.InputHandler.bind(KeyCode.Space,"Space");
        Utils.InputHandler.bind(KeyCode.W,"W");
    }

    // Update is called once per frame
    void Update()
    {
        Utils.InputHandler.Update(); // вызов update для InputHanlder
        if (isMoving)
        {
            xPosition += 0.05f * direction;
            this.transform.position = new Vector3(xPosition,0,-5);
            if(xPosition <= -10 || xPosition >= 10){
                direction *= -1;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            isMoving = !isMoving;
        }
    }
}
