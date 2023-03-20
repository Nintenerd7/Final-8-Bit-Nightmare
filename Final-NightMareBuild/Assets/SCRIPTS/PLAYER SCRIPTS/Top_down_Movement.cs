using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace com.InfallibleCode.TurnBasedGame.Combat
{
    public class Top_down_Movement : MonoBehaviour
    {
        #region Variables
        public float wasdSpeed = 5f;
        public LayerMask GrassLayer;
        public LayerMask SolidEnviorments;

        //checking if player is moving 
        private bool isMoving;
        private Vector2 MoveInput;
        public BattleOperator BattleEnabled;
        #endregion
        #region Player Movement
        //MOVEMENT//
        private void Update()
        {
            if (!isMoving)//if player is not moving
            {
                //allows player to move
                MoveInput.x = Input.GetAxisRaw("Horizontal");
                MoveInput.y = Input.GetAxisRaw("Vertical");
                //

                //removes diagonal movement
                if (MoveInput.x != 0) MoveInput.y = 0;
                //

                //calculates where the player will move
                if (MoveInput != Vector2.zero)
                {
                    var targetPos = transform.position;
                    targetPos.x += MoveInput.x;
                    targetPos.y += MoveInput.y;

                    //if you dont collide with any objects
                    if (IsWalkable(targetPos))
                        StartCoroutine(Move(targetPos));
                }
                //
            }


        }
        #endregion
        #region Player moving tile by tile
        IEnumerator Move(Vector3 targetPos)
        {
            //player is moving
            isMoving = true;

            //lets player move tile by tile
            while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos, wasdSpeed * Time.deltaTime);
                yield return null;
            }
            transform.position = targetPos;
            //

            //player is not moving
            isMoving = false;

            //Enables encounters
            CheckForEncounters();
            //
        }
        #endregion
        #region Colliding With solid Objects
        private bool IsWalkable(Vector3 targetPos)
        {
            //enables collisisions for interactive objects
            if (Physics2D.OverlapCircle(targetPos, 0.3f, SolidEnviorments) != null)
            {
                return false;
            }
            //
            return true;
        }
        #endregion
        #region Encounters
        private void CheckForEncounters()
        {
            if (Physics2D.OverlapCircle(transform.position, 0.2f, GrassLayer) != null)
            {
                //dice roll for when battle is enabled
                if (Random.Range(1, 150) <= 10)
                {
                    BattleEnabled.BattleMenuON();
                }
                //end if
            }
        }
        #endregion
    }
}
