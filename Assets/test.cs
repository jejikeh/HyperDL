using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using Movenment;
public class test : MonoBehaviour, TetrisClass
{
    //private Keycode[] actionMove;
    public Vector3 OffsetCam = new Vector3(0,0,-5);

    void Start()
    {
        Utils.CameraControll.setCameraTarget(transform,OffsetCam);
    }

    // Update is called once per frame
    void Update()
    {

        /*if(Utils.InputHandler.pressed("Move")){
        }*/
    }

    public void Move(){
        throw new System.NotImplementedException();
    }
}
