﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform followTransform;
  
    void FixedUpdate()
    {
      
        this.transform.position = new Vector3(followTransform.position.x,followTransform.position.y,this.transform.position.z);
        
        
    }
}
