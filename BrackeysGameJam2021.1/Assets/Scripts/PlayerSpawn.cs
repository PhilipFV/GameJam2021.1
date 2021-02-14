using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
	public int playerID; // 1 for player one, 2 for p

    public GameObject playerOnePrefab; //player prefab To spawn when the game starts and when the player respawns
    public GameObject playerTwoPrefab;

    void Start()
    {
    	SpawnPlayer(playerID);
    }

    public void SpawnPlayer (int ID)
    {
    	switch (ID) 
    	{
    		case 0:
    		  
    		  	break;
    		case 1:
    		   
    			break;
    	}
    }
}
