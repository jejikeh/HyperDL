using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using Effects;
using Movenment;

public class move : MonoBehaviour
{
    SpriteRenderer sprite;
    public Vector3 OffsetCam = new Vector3(0,0,-5);

    private Transform pos;
    private float previousTime;
    public float fallTime = 4f;
    void Start()
    {
        pos = GetComponent<Transform>();

        Utils.CameraControll.setCameraTarget(pos,OffsetCam);

        Utils.InputHandler.bind(KeyCode.A,KeyCode.LeftArrow,"Left");
        Utils.InputHandler.bind(KeyCode.D,KeyCode.RightArrow,"Right");
        Utils.InputHandler.bind(KeyCode.W,KeyCode.UpArrow,"Up");
        Utils.InputHandler.bind(KeyCode.S,KeyCode.DownArrow,"Down");
        //Utils.InputHandler.bind(KeyCode.G,KeyCode.JoystickButton14,"Shadow");

    }

    // Update is called once per frame
    void Update()
    {
        if(Utils.InputHandler.pressed("Left")){
            Movenment.MovenmentSystem.moveTo(this.transform,new Vector3(-1,0,0),true);
        } 
        if(Utils.InputHandler.pressed("Right")){
            Movenment.MovenmentSystem.moveTo(this.transform,new Vector3(1,0,0),true);
        }

        /*if(Time.time - previousTime > (Utils.InputHandler.down("Down") ? fallTime/10 : (Utils.InputHandler.down("Up") ? fallTime*2 : fallTime))){
            Movenment.MovenmentSystem.moveTo(this.transform,new Vector3(0,-1,this.transform.position.z),true);
            previousTime = Time.time;
        }*/

        if(Utils.Timer.every(fallTime)){
            Movenment.MovenmentSystem.moveTo(this.transform,new Vector3(0,-1,0),true);
        }
        

        /*if(Utils.InputHandler.pressed("Shadow")){
            Utils.CameraControll.setCameraTarget(pos,OffsetCam);
        } */

        /*if(Input.GetKeyDown(KeyCode.Space)){
            isMoving = !isMoving;
        }*/

    }
}
