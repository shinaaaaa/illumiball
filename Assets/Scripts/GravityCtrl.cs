using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCtrl : MonoBehaviour {
    const float gravity = 9.8f; //gravity acceleration
    public float gravityScale = 1.0f; //gravity accelertion scale

    void Update () {
        Vector3 vector = new Vector3 ();
        if(Application.isMobilePlatform){
            vector.x = Input.acceleration.x;
            vector.y = Input.acceleration.y;
            vector.z = Input.acceleration.z;
        }
        //detect key ->set vector
        vector.x = Input.GetAxis("Horizontal");
        vector.y = Input.GetAxis("Vertical");

        //hight->Z key
        if(Input.GetKey("z")){
            vector.y = 1.0f;
        }else{
            vector.y = -1.0f;
        }
        //change scene gravity,input vector
        Debug.Log(gravity * vector.normalized * gravityScale);
        Physics.gravity = gravity * vector.normalized * gravityScale;
    }

    void FixedUpdate () {

    }

}