using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace com.InfallibleCode.TurnBasedGame.Combat
{
    //-------KATIE WALKER--------//
    public class Dialogue : MonoBehaviour
    {
        public TextMeshProUGUI textComponent; //text 
        public string[] lines; // how many lines you want
        public float textSpeed; // speed 
        public Top_down_Movement PlayerSpeed; // player speed
        private int index; 

        // Start is called before the first frame update
        void Start()
        {
            textComponent.text = string.Empty;
            StartDialogue(); //start dialogue when games starts
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0)) //right mouse button click then do this
            {
                if (textComponent.text == lines[index])//if lines are fufilled do this 
                {
                    NextLine(); //next line

                }
                else
                {
                    StopAllCoroutines(); //stop
                    textComponent.text = lines[index];
                }
            }
        }

        void StartDialogue() // start dialogue
        {
            PlayerSpeed.wasdSpeed = 0;//movement speed set 0
            index = 0;
            StartCoroutine(TypeLine());//typing lines
        }

        IEnumerator TypeLine()
        {
            foreach (char c in lines[index].ToCharArray())
            {
                textComponent.text += c;
                yield return new WaitForSeconds(textSpeed);

            }
        }

        void NextLine()
        {
            if (index < lines.Length - 1)
            {
                index++;
                textComponent.text = string.Empty;
                StartCoroutine(TypeLine());

            }
            else
            {
                PlayerSpeed.wasdSpeed = 5;
                gameObject.SetActive(false);

            }
        }
    }
}
