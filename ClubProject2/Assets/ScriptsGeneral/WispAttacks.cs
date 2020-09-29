using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WispAttacks : MonoBehaviour  
{
    public float radius;
    public System.String enemyTag;
    public Animator lightAnim;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !lightAnim.GetBool("isClicked"))
        {
            print("Click");
            
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, radius);
            foreach (var hitCollider in hitColliders)
            {
                print(hitCollider);
                if (hitCollider.tag == enemyTag){
                    Destroy(hitCollider.gameObject);
                }
            }
            lightAnim.SetBool("isClicked", true);
            Invoke("setClickFalse", 1);
            

        }

    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
    public void setClickFalse()
    {
        lightAnim.SetBool("isClicked", false);

    }
}
