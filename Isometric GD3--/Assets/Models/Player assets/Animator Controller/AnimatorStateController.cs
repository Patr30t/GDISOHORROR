using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStateController : MonoBehaviour
{

    Animator anim;
    float velocity = 0.0f;
    public float acceleration = 1f;
    public float deceleration = 1f;
    int VelocityHashNumber;
     


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        VelocityHashNumber = Animator.StringToHash("Velocity");
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

       bool forwardPressed = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);

       if (forwardPressed && velocity < 1.0f)
       {
         velocity += Time.deltaTime * acceleration;
       }
       anim.SetFloat(VelocityHashNumber, velocity);

       if (!forwardPressed && velocity > 0.0f)
       {
         velocity -= Time.deltaTime * acceleration;
       }
       anim.SetFloat(VelocityHashNumber, velocity);

     }
     
      
    }