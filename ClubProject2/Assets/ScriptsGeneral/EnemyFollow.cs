using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

    public float speed = 0.0f;
    public float stoppingDistance = 0.0f;
    public GameObject targetObject;
    private Transform target;
    private Vector2 lastPos;
    private float differenceOfPos;


	// Use this for initialization
	void Start () {
        target = targetObject.GetComponent<Transform>();
        lastPos = new Vector2(0f, 0f);

	}
	
	// Update is called once per frame
	void Update () {

        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        differenceOfPos = transform.position.x - lastPos.x;
        if (differenceOfPos >= 2f)
        {
            transform.localScale = new Vector2(1f,1f);
        }
        else if (differenceOfPos < 0f)
        {
            transform.localScale = new Vector2(-1f,  1f);
        }


        lastPos = transform.position;


    }

    /*private void FixedUpdate()
    {

        if (rb.velocity.magnitude >= .01f)
        {
            transform.localScale = new Vector2(transform.localScale.x * 1f, transform.localScale.y * 1f);
        }
        else if (rb.velocity.magnitude < .01f)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1f, transform.localScale.y * 1f);
        }

    }*/

    /* void OnTriggerEnter2D(Collider2D hitInfo)
     {
         Debug.Log(hitInfo.name);

         if(hitInfo.name == target.name)
         {
             Destroy(gameObject);
         }

     }
     */

}
