using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    //-------KATIE WALKER--------//

    public bool isInRange; // 
    public KeyCode interactKey;
    public UnityEvent interactAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange) //if were in range to interact
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke(); //invoke event

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("player in range");

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
        Debug.Log("player not in range");
    }


}
