using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier_Spartial
    {
        //To change material
        public MeshRenderer soldierMeshRenderer;
        //To move the soldier
        public Transform soldierTrans;
        //The speed the soldier is walking with
        protected float walkSpeed;
        //Has to do with the grid, so we can avoid storing all soldiers in an array
        //Instead we are going to use a linked list where all soldiers in the cell 
        //Are linked to each other
        public Soldier_Spartial previousSoldier;
        public Soldier_Spartial nextSoldier;

        //The enemy doesnt need any outside information
        public virtual void Move()
        { }

        //The friendly has to move which soldier is the closest
        public virtual void Move(Soldier_Spartial soldier)
        { }
    }
