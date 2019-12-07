using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friendly_Spartial : Soldier_Spartial
    {
        //init friendly
        public Friendly_Spartial(GameObject soldierObj, float mapWidth)
        {
            this.soldierTrans = soldierObj.transform;

            this.walkSpeed = 2f;
        }


        //Move towards the closest enemy - will always move within its grid
        public override void Move(Soldier_Spartial closestEnemy)
        {
            //Rotate towards the closest enemy
            soldierTrans.rotation = Quaternion.LookRotation(closestEnemy.soldierTrans.position - soldierTrans.position);
            //Move towards the closest enemy
            soldierTrans.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
        }
    }
