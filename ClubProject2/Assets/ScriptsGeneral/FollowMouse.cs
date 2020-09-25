using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    private float temp = 1f;

    void Update()
    {
        
        transform.position = new Vector3(Input.mousePosition.x,Input.mousePosition.y, temp);        
        
    }
}
