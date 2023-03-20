using System.Collections;
using System.Collections.Generic;
using UnityEngine;


  namespace com.InfallibleCode.TurnBasedGame.Combat
{
  
    public abstract class State
    {
        protected BattleOperator BattleOperator;
        public State(BattleOperator battleOperator)
        {
            BattleOperator = battleOperator;
        }
        public virtual IEnumerator Start()
        {
            yield break;
        }
        public virtual IEnumerator Attack()
        {
            yield break;
        }

    }
}

