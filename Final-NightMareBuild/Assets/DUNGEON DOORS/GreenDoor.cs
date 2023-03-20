using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenDoor : MonoBehaviour
{
    // Reference to the red door game object
    public GameObject DungeonDoorGREEN;

    // Reference to the red button sprite renderer
    public SpriteRenderer GreenButtonSpriteRenderer;

    // Reference to the new red button sprite
    public Sprite GreenButtownDown;

    // Method called when the player touches the red button
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Change the red button sprite to the new sprite
            GreenButtonSpriteRenderer.sprite = GreenButtownDown;

            // Destroy the red door game object
            Destroy(DungeonDoorGREEN);
        }
    }
}
