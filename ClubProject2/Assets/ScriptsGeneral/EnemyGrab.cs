using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGrab : MonoBehaviour
{

    private GameObject player;

    private void OnCollisionStay2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag.Contains("Player"))
        {
            print("Player Grabbed");
            player = collision.gameObject;
            (player.GetComponent("Player_Moverment") as MonoBehaviour).enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag.Contains("Player"))
        {
            print("Player Grabbed");
            player = collision.gameObject;
            (player.GetComponent("Player_Moverment") as MonoBehaviour).enabled = false;
        }
    }
}
