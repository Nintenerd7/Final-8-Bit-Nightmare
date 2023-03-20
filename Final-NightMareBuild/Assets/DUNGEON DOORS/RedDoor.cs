using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDoor : MonoBehaviour
{
    // Reference to the red door game object
    public GameObject DungeonDoorRED;

    // Reference to the red button sprite renderer
    public SpriteRenderer redButtonSpriteRenderer;

    // Reference to the new red button sprite
    public Sprite RedButtownDown;

    // Method called when the player touches the red button
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Change the red button sprite to the new sprite
            redButtonSpriteRenderer.sprite = RedButtownDown;

            // Destroy the red door game object
            Destroy(DungeonDoorRED);
        }
    }
}
