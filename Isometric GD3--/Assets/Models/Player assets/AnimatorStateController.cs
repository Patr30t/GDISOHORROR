﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStateController : MonoBehaviour
{

    Animator anim;
     


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKey("w")) 
     {
       anim.SetBool("IsRunning", true);

     }

     if (!Input.GetKey("w"))
     {
       anim.SetBool("IsRunning", false);
     }
     
      
    }
}

