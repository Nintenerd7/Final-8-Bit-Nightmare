using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToDungeon : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "CircleCave")
        {
            transform.position = new Vector2(156f, -56f);
        }
    }
}
