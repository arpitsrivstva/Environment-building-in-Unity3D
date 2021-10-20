using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstperson : MonoBehaviour
{ public float rspeed = 40f;
public GameObject Sphere;
public GameObject Camera;

    // Update is called once per frame
    void Update()
    { 
       Camera.transform.Rotate(-Input.GetAxis("Mouse Y")*Time.deltaTime*rspeed,0,0);
       Sphere.transform.Rotate(0,Input.GetAxis("Mouse X")*Time.deltaTime*rspeed,0);
       
    }
}
