using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class BattleOutcome : MonoBehaviour
    {
        public GameObject WinScreen;
        public GameObject BattleEnd;
        public GameObject GameOver;
       [SerializeField] public  EnemyLife EnemyHP;
       [SerializeField] public PlayerLife PlayerHP;
        public IEnumerator YouWon()
        {
            WinScreen.SetActive(true);
            RestoreHP();
            yield return new WaitForSeconds(5f);
            WinScreen.SetActive(false);
            BattleEnd.SetActive(false);

        }
        public void YouLost()
        {
            RestoreHP();
            GameOver.SetActive(true);
        }
        public  void RestoreHP()
        {
            EnemyHP.totalHealth = 6.3875f;
            PlayerHP.totalHealth = 6.3875f;
        }

    }
}

