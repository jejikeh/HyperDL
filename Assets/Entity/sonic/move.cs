using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using Effects;

public class move : MonoBehaviour
{
    float xPosition = 0;
    float yPosition = 0;
    SpriteRenderer sprite;
    public Vector3 OffsetCam = new Vector3(0,0,-10);

    public Transform pos;
    void Start()
    {
        pos = GetComponent<Transform>();

        Utils.CameraControll.setCameraTarget(pos,OffsetCam);

        Utils.InputHandler.bind(KeyCode.A,KeyCode.JoystickButton3,"Left");
        Utils.InputHandler.bind(KeyCode.D,KeyCode.JoystickButton2,"Right");
        Utils.InputHandler.bind(KeyCode.W,KeyCode.JoystickButton2,"Up");
        Utils.InputHandler.bind(KeyCode.S,KeyCode.JoystickButton2,"Down");
        Utils.InputHandler.bind(KeyCode.G,KeyCode.JoystickButton2,"Shadow");

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
