using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{

    public float timeLeft = 30.0f;


    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0f)
        {
            //End game
            //guiText.text = "You ran out of time"
            SceneManager.LoadScene("Prototype build Level");
        }
        
    }
}
