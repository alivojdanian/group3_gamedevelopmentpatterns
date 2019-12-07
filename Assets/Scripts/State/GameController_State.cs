using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController_State : MonoBehaviour
{
    public GameObject playerObj;
        public GameObject creeperObj;
        public GameObject skeletonObj;

        //A list that will hold all enemies
        List<Enemy_State> enemies = new List<Enemy_State>();

        
        void Start()
        {
            //Add the enemies we have
            enemies.Add(new Creeper_State(creeperObj.transform));
            enemies.Add(new Skeleton_State(skeletonObj.transform));
        }


        void Update()
        {
            //Update all enemies to see if they should change state and move/attack player
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].UpdateEnemy(playerObj.transform);
            }
        }
}
