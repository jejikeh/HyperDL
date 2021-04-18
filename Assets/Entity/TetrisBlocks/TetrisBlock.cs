using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisBlock : MonoBehaviour, TetrisClass
{

    public void Start(){

        KeyCode[] actionMove = new KeyCode[] {KeyCode.A,KeyCode.LeftArrow};


        Utils.InputHandler.bind(
            actionMove,"Run"
        );
    }
    public void Run(){
        transform.position += new Vector3(0,-1 * Time.deltaTime,0);
    }
    public void Run1(){
        transform.position += new Vector3(0,1* Time.deltaTime,0);
    }

    public void Update(){
        if(Input.touchCount == 1){
            Touch touch = Input.GetTouch(0);
            Run();
        }else if(Input.touchCount == 2){
            Run1();

        }
    }

    public void Move(){
        Run();
    }
}
