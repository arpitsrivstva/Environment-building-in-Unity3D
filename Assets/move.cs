using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{ 
    public float speed = 10f;
    

    Vector3 velocity = Vector3.zero;
    
    // Update is called once per frame
    void Update()
    { 
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*speed,0,Input.GetAxis("Vertical")*Time.deltaTime*speed);

        if(velocity.y < 0)
        {
            
        }
    }
}