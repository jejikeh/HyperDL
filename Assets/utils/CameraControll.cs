using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils{
    public class CameraControll : MonoBehaviour
    {
        public static camera cam;
        [Range(0,10)]
        public float smooth;
        public static void setCameraTarget(Transform target,Vector3 offset){
            cam = new camera(target,offset);
        }

        void FixedUpdate(){
            //transform.position = cam.target.position + cam.offset;
            follow();
        }

        void follow(){
            Vector3 targetPosition = cam.target.position + cam.offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position,targetPosition,smooth * Time.deltaTime);
            transform.position = smoothPosition;
        }
    }
    public class camera{
        public Transform target;
        public Vector3 offset;

        public camera(Transform target,Vector3 offset){
            this.target = target;
            this.offset = offset;
        }
    }
}
