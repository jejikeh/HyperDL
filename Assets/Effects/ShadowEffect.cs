using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Effects {
    public class ShadowEffect : MonoBehaviour
    {
        public Vector3 offset = new Vector3(-3,-3,-3);
        private SpriteRenderer sprRndCaster;
        private SpriteRenderer sprRndShadow;

        private Transform transCaster;
        private Transform transShadow;
        public Material Material;

        void Start(){
            transCaster = transform;
            transShadow = new GameObject().transform;
            transShadow.parent = transCaster;
            transShadow.gameObject.name = "shadow";
            transShadow.localRotation = Quaternion.identity;

            sprRndCaster = GetComponent<SpriteRenderer>();
            sprRndShadow = transShadow.gameObject.AddComponent<SpriteRenderer>();

            sprRndShadow.sortingLayerName = sprRndCaster.sortingLayerName;
            sprRndShadow.sortingOrder = sprRndCaster.sortingOrder - 1;

            sprRndShadow.material = Material;

        }

        void LateUpdate(){
            transShadow.position = new Vector3(transCaster.position.x+ offset.x,
                transCaster.position.y + offset.y,
                transCaster.position.z + offset.z);
            sprRndShadow.sprite = sprRndCaster.sprite;

        }


    }
}
