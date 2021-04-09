using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class move : MonoBehaviour
{
    float xPosition = 0;
    float yPosition = 0;
    void Start()
    {
        Utils.InputHandler.bind(KeyCode.A,KeyCode.JoystickButton3,"Left");
        Utils.InputHandler.bind(KeyCode.D,KeyCode.JoystickButton2,"Right");
        Utils.InputHandler.bind(KeyCode.W,KeyCode.JoystickButton2,"Up");
        Utils.InputHandler.bind(KeyCode.S,KeyCode.JoystickButton2,"Down");
    }

    // Update is called once per frame
    void Update()
    {
        if(Utils.InputHandler.down("Left")){
            xPosition += 5f * -1 * Time.deltaTime;
            this.transform.position = new Vector3(xPosition,yPosition,-5);
        } 
        if(Utils.InputHandler.down("Right")){
            xPosition += 5f * 1 * Time.deltaTime;
            this.transform.position = new Vector3(xPosition,yPosition,-5);
        }
        if(Utils.InputHandler.down("Up")){
            yPosition += 5f * 1 * Time.deltaTime;
            this.transform.position = new Vector3(xPosition,yPosition,-5);
        }
        if(Utils.InputHandler.down("Down")){
            yPosition += 5f * -1 * Time.deltaTime;
            this.transform.position = new Vector3(xPosition,yPosition,-5);
        }

        /*if(Input.GetKeyDown(KeyCode.Space)){
            isMoving = !isMoving;
        }*/

    }
}
