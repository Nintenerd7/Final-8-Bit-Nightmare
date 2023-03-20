using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDoor : MonoBehaviour
{
    // Reference to the red door game object
    public GameObject DungeonDoorBLUE;

    // Reference to the red button sprite renderer
    public SpriteRenderer BlueButtonSpriteRenderer;

    // Reference to the new red button sprite
    public Sprite BlueButtownDown;

    // Method called when the player touches the red button
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Change the red button sprite to the new sprite
            BlueButtonSpriteRenderer.sprite = BlueButtownDown;

            // Destroy the red door game object
            Destroy(DungeonDoorBLUE);
        }
    }
}
