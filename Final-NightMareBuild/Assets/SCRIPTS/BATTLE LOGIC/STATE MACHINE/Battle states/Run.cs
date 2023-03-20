using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class Run : State
    {
        #region Constructor
        public Run(BattleOperator battleOperator) : base(battleOperator)
        {
        }
        #endregion
        // Start is called before the first frame update
        public override IEnumerator Start()
        {
            BattleOperator.BattleOptionsOFF();
            BattleOperator.BattleText.text = "you got away safely";
            yield return new WaitForSeconds(2f);
            BattleOperator.BattleMenuOFF();
            BattleOperator.ResetHealth();
           
        }

    }
}
