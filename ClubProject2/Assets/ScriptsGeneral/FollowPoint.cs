using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPoint : MonoBehaviour
{
    //Object that is being tracked
    public GameObject target;
    private Transform follower;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        follower = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        follower.position = target.GetComponent<Transform>().position + offset;
        
    }
}
