using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class PlayerLife : MonoBehaviour
    {
        // Start is called before the first frame update
        public static RectTransform bar;
        public float totalHealth = 6.3875f;
        public BattleOutcome Loose;
        void Start()
        {
            bar = GetComponent<RectTransform>();
            SetSize(totalHealth);
        }
        public void Damage(float damage)
        {
            if ((totalHealth -= damage) >= 0f)
            {
                totalHealth -= damage;
            }
            else if (totalHealth <= 0)
            {
                //ends battle
                Loose.YouLost();
            }
            SetSize(totalHealth);
        }

        public static void SetSize(float size)
        {
            bar.localScale = new Vector3(size, 0.7265625f);
        }
    }
}
