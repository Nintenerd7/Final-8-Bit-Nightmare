using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCount : MonoBehaviour
{
    private int coins = 0;

    [SerializeField] private TextMeshProUGUI coinText;

      public AudioSource collectSound;

    void OnTriggerEnter2D(Collider2D collision)

        
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
             collectSound.Play();
            coins++;
            coinText.text = "Coins: " + coins;
        }
    }
}
