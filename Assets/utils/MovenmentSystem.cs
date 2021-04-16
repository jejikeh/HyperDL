using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Movenment{
    public class MovenmentSystem : MonoBehaviour
    {
        static int height = 7;
        static int width = 8;
        public static void moveTo(Transform transform,Vector3 vec,bool outOf){
            if(outOf){
                foreach(Transform children in transform){
                    int rX = Mathf.RoundToInt(children.transform.position.x);
                    int rY = Mathf.RoundToInt(children.transform.position.y);
                    if(rX < -width){
                        transform.position += new Vector3(1,0,0);
                    }else if(rX >= width){
                        transform.position -= new Vector3(1,0,0);
                    }
                    else{
                        transform.position += vec;
                    }
                }
            }
            //Vector3 smoothVec = Vector3.Lerp(transform.position,vec, 1 * Time.deltaTime);
        }
    }
}
