using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class EnemyTurn : State
    {
        #region Constructor
        public EnemyTurn(BattleOperator battleOperator) : base(battleOperator)
        {
        }
        #endregion
        public override IEnumerator Start()
        {
            BattleOperator.BattleOptionsOFF();
            BattleOperator.BattleText.text = "Enemy Attacks";
            yield return new WaitForSeconds(2f);
            BattleOperator.AITurn.HitPlayer();
            BattleOperator.SetState(new PlayerTurn(BattleOperator));//switches back to enemy
            //call hitplayer here 
        }
    }
}
