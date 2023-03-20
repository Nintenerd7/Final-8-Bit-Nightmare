using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class AttackPlayer : MonoBehaviour
    {
        //where damage will be dealt to enemy healthbar
        //variables

        public PlayerLife PlayerHealth;//global name for enemy healthbar class 
        [SerializeField] public TMP_Text ChanceText;
        //get enemy healthbar class
        private void Start()
        {
            PlayerHealth.GetComponent<PlayerLife>();//gets enemy healthbar components
        }
        //where the logic goes
        public void HitPlayer()
        {
            if (Random.Range(0, 6) >= 2)
            {
                PlayerHealth.Damage(0.2f);
                ChanceText.text = "good!";
            }
            else if (Random.Range(0, 6) >= 5)
            {
                PlayerHealth.Damage(0.6f);
                ChanceText.text = "Nice Crit";
            }
            else
            {
                PlayerHealth.Damage(0f);
                ChanceText.text = "Enemy Missed";
            }
        }
        //end of code

    }
}
