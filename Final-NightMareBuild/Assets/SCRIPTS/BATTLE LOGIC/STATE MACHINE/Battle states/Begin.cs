using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class Begin : State
{
        #region Constructor
        public Begin(BattleOperator battleOperator) : base(battleOperator)
        {
        }
        #endregion
        public override IEnumerator Start()
        { 
            BattleOperator.BattleText.text = "It's an enemy!";
            BattleOperator.BattleOptionsOFF();
            yield return new WaitForSeconds(2f);
            BattleOperator.SetState(new PlayerTurn(BattleOperator));        
        }
    }
}

