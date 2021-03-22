using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int playerHealth = 40;
    int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     private void OnCollisionEnter(Collision _collision)
     {
         if(_collision.gameObject.tag=="enemyAttack")
         {
             print ("playerHealth lost");
         }
     }
        
        
}
