using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid_Spartial
    {
        //Need this to convert from world coordinate position to cell position
        int cellSize;

        //This is the actual grid, where a soldier is in each cell
        //Each individual soldier links to other soldiers in the same cell
        Soldier_Spartial[,] cells; 


        //Init the grid
        public Grid_Spartial(int mapWidth, int cellSize)
        {
            this.cellSize = cellSize;

            int numberOfCells = mapWidth / cellSize;

            cells = new Soldier_Spartial[numberOfCells, numberOfCells];
        }


        //Add a unity to the grid
        public void Add(Soldier_Spartial soldier)
        {
            //Determine which grid cell the soldier is in
            int cellX = (int)(soldier.soldierTrans.position.x / cellSize);
            int cellZ = (int)(soldier.soldierTrans.position.z / cellSize);

            //Add the soldier to the front of the list for the cell it's in
            soldier.previousSoldier = null;
            soldier.nextSoldier = cells[cellX, cellZ];

            //Associate this cell with this soldier
            cells[cellX, cellZ] = soldier;

            if (soldier.nextSoldier != null)
            {
                //Set this soldier to be the previous soldier of the next soldier of this soldier (linked lists ftw)
                soldier.nextSoldier.previousSoldier = soldier;
            }
        }


        //Get the closest enemy from the grid
        public Soldier_Spartial FindClosestEnemy(Soldier_Spartial friendlySoldier)
        {
            //Determine which grid cell the friendly soldier is in
            int cellX = (int)(friendlySoldier.soldierTrans.position.x / cellSize);
            int cellZ = (int)(friendlySoldier.soldierTrans.position.z / cellSize);

            //Get the first enemy in grid
            Soldier_Spartial enemy = cells[cellX, cellZ];

            //Find the closest soldier of all in the linked list
            Soldier_Spartial closestSoldier = null;

            float bestDistSqr = Mathf.Infinity;

            //Loop through the linked list
            while (enemy != null)
            {
                //The distance sqr between the soldier and this enemy
                float distSqr = (enemy.soldierTrans.position - friendlySoldier.soldierTrans.position).sqrMagnitude;

                //If this distance is better than the previous best distance, then we have found an enemy that's closer
                if (distSqr < bestDistSqr)
                {
                    bestDistSqr = distSqr;

                    closestSoldier = enemy;
                }

                //Get the next enemy in the list
                enemy = enemy.nextSoldier;
            }

            return closestSoldier;
        }


        //A soldier in the grid has moved, so see if we need to update in which grid the soldier is
        public void Move(Soldier_Spartial soldier, Vector3 oldPos)
        {
            //See which cell it was in 
            int oldCellX = (int)(oldPos.x / cellSize);
            int oldCellZ = (int)(oldPos.z / cellSize);

            //See which cell it is in now
            int cellX = (int)(soldier.soldierTrans.position.x / cellSize);
            int cellZ = (int)(soldier.soldierTrans.position.z / cellSize);

            //If it didn't change cell, we are done
            if (oldCellX == cellX && oldCellZ == cellZ)
            {
                return;
            }

            //Unlink it from the list of its old cell
            if (soldier.previousSoldier != null)
            {
                soldier.previousSoldier.nextSoldier = soldier.nextSoldier;
            }

            if (soldier.nextSoldier != null)
            {
                soldier.nextSoldier.previousSoldier = soldier.previousSoldier;
            }

            //If it's the head of a list, remove it
            if (cells[oldCellX, oldCellZ] == soldier)
            {
                cells[oldCellX, oldCellZ] = soldier.nextSoldier;
            }

            //Add it bacl to the grid at its new cell
            Add(soldier);
        }
    }
