using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WispAttacks : MonoBehaviour  
{
    public float radius;
    public System.String enemyTag;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Click");
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
            foreach (var hitCollider in hitColliders)
            {
                print(hitCollider);
                if (hitCollider.tag == enemyTag){
                    Destroy(hitCollider);
                }
            }
        }
            
    }
}
