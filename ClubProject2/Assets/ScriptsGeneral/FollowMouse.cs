using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    public float speed = 0.0f;
    public float stoppingDistance = 0.0f;
    public Camera cam;
    private Vector3 target;


    // Update is called once per frame
    void Update()
    {
        target = cam.ScreenToWorldPoint(Input.mousePosition);
        target.z = -.10f;
        //target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //target = new Vector2(target.x, target.y);
        print(target);
        if (Vector2.Distance(transform.position, target ) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }
}
