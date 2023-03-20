using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class PlayerTurn : State
    {
        #region Constructor
        public PlayerTurn(BattleOperator battleOperator) : base(battleOperator)
        {
        }
        #endregion
        public override IEnumerator Start()
        {
            BattleOperator.BattleText.text = "Choose an action";
            yield return new WaitForSeconds(2f);
            BattleOperator.BattleOptionsON();
            yield break;
        }
        public override IEnumerator Attack()
        {
            BattleOperator.BattleOptionsOFF();
            BattleOperator.BattleText.text = "You attacked";
            yield return new WaitForSeconds(2f);//yields for 2 seconds
            BattleOperator.AttackTurn.HitEnemy();//attacks enemy on rng based crit 
            BattleOperator.SetState(new EnemyTurn(BattleOperator));//enemy turn starts
            
        }
    }
}
