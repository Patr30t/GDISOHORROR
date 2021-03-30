using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePush : MonoBehaviour
{
    public float pushLevel;
    public float forcePushRadius;

    // Start is called before the first frame update
   private  void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ExecutePush();
        }
    }

  private void ExecutePush()
  {
      Collider[] colliders = Physics.OverlapSphere(transform.position, forcePushRadius);

      foreach (Collider pushedObject in colliders)
      {
          if(pushedObject.CompareTag("Enemy"))
          {
              Rigidbody pushedBody = pushedObject.GetComponent<Rigidbody>();

              pushedBody.AddExplosionForce(pushLevel, Vector3.up, forcePushRadius);
          }
      }
  }
}
