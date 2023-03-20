using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class AttackEnemy : MonoBehaviour
    {
        //where damage will be dealt to enemy healthbar
        //variables

        public EnemyLife EnemyHealth;//global name for enemy healthbar class 
        [SerializeField] public TMP_Text ChanceText;
        #region Getting Components from Enemy HP class
        private void Start()
        {
            EnemyHealth.GetComponent<EnemyLife>();//gets enemy healthbar components
        }
        #endregion

        #region Player Hitting enemy
        public void HitEnemy()
        {
            #region Random chance attack
            if (Random.Range(0, 6) >= 2)//if random range is more or equal to two
            {
                EnemyHealth.Damage(1f);
                ChanceText.text = "good!";
            }
            else if (Random.Range(0, 6) >= 4)//if random range is equal to six
            {
                EnemyHealth.Damage(3f);
                ChanceText.text = "Nice Crit";
            }
            else//if it is less than that
            {
                EnemyHealth.Damage(0f);
                ChanceText.text = "You Missed";
            }
            #endregion
        }
        #endregion


    }
}
