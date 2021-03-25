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
     
       anim.SetFloat("Vertical", Input.GetAxis("Vertical"));
       anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

       if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D))
       {
         anim.SetBool("IsRunning", true);

       } else{
         anim.SetBool("IsRunning", false);
       }

     }
     
      
    }


