using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToOutside : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "DungeonCircle")
        {
            transform.position = new Vector2(58f, -36f);
        }
    }
}