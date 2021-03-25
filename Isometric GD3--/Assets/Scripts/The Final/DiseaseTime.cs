using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiseaseTime : MonoBehaviour
{

    public CountdownTimer countdowntimer;

    // Update is called once per frame
    void Update()
    {
        countdowntimer = GetComponent<CountdownTimer>();

    }

    //pickup
    void OnTriggerEnter(Collider other) 
    {
        
            if(other.gameObject.tag == "Pickup")
            {
                // addtime

                Destroy(other.gameObject);
                //
                countdowntimer.timeLeft += 10;
            }
        
    }
}
