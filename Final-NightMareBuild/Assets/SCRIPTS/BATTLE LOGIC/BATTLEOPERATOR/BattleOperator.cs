using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class BattleOperator : StateMachine
    {
        #region Variables
        [SerializeField] public AttackEnemy AttackTurn;
        [SerializeField] public AttackPlayer AITurn;
        [SerializeField] public BattleOutcome HealthReset;
        [SerializeField] public TMP_Text BattleText;
        public GameObject BattleMenu;
        public GameObject Dial;
        public GameObject TextBox;
        #endregion 
        #region Start
        private void Start()
        { 
            BattleMenuON();
        }
        #endregion
        #region ButtonFunctions

        //Fight Button
        public void OnAttack()
        {
            StartCoroutine(State.Attack());//attack turn begins
        }
        public void OnRun()
        {
            SetState(new Run(this));//sets state to flee
        }
        #endregion
        #region Methods
        public void BattleOptionsON()
        {
          Dial.SetActive(true);
          TextBox.SetActive(false);
        }
        public void BattleOptionsOFF()
        {
          Dial.SetActive(false);
          TextBox.SetActive(true);
        }
        public void BattleMenuOFF()
        {
            BattleMenu.SetActive(false);
        }

        public void BattleMenuON()
        {
            BattleMenu.SetActive(true);
            SetState(new Begin(this));
        }
        public void ResetHealth()
        {
           HealthReset.RestoreHP();
        }
        #endregion
    }
}

