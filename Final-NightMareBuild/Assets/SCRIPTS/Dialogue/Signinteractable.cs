using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Signinteractable : MonoBehaviour
{
    //-------KATIE WALKER--------//

    public GameObject SignDialogBox; // refrence the game object dialog box

    public TextMeshProUGUI dialogText; // refrence dialog text 

    public KeyCode interactKey; //allows me to choose the key 

    public string Dialog; // creating dialog

    public bool PlayerinRange;//checking if player is in range of the sign 

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(interactKey) && PlayerinRange)//key pressed in range of sign do this
        {
            if (SignDialogBox.activeInHierarchy) //if sign is active in hierarchy do this
            {
                SignDialogBox.SetActive(false);//set the box to inactive - its hidden
            }
            else
            {
                SignDialogBox.SetActive(true);//set the box to active - its seen
              
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)//when entering the cicle collider do this
    {
        if (other.CompareTag("Player")) //if player enters collider do this
        {
            PlayerinRange = true; // means player is in range of the sign 
        }
    }

    private void OnTriggerExit2D(Collider2D other)//when exiting the cicle collider do this
    {
        if (other.CompareTag("Player"))//if player exits collider do this
        {
            PlayerinRange = false; // means player is not in range of the sign 
        }
    }

}
