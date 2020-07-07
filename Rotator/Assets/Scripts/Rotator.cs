using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float speed = 0.4F;
  //Assign a GameObject in the Inspector to rotate around
    public GameObject target;

    void Update()
    {
        
//transform.Rotate(Vector3.up * speed);
           transform.Rotate(Vector3.forward * speed);
      //  transform.Rotate(Vector3.right * speed);

    }
}
