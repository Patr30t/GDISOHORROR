using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itempickup : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy (gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
