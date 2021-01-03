using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject[] gameTiles;
    public GameObject[] playersByTurn;
    public int          activePlayer;
    public int          currentTile;
    public bool isCountdownOn;
    public int diceRoll;
    void Start()
    {
        //Player turn defination function will calls here
        isCountdownOn = true;
        //This if for test will change lately
        activePlayer = 0;
        currentTile = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        while (isCountdownOn==true)
        {
            //First Actived Player

            //Second Calls Dice Roll Phase Function

            //Move Phase Function
            for (int i = 0; i < diceRoll; i++)
            {
                Debug.Log("I value" + i);
                Debug.Log("Dice Roll:" + diceRoll);
                //%20 For Stay in array bounds
                playersByTurn[activePlayer].GetComponent<MoveFunctionScript>().StartMovingFunction(gameTiles[(currentTile + 1)%20].transform);
                currentTile++;
                StartCoroutine(Wait2Second());
            }

            isCountdownOn = false;
        }

    }

    IEnumerator Wait2Second()
    {
        Debug.Log("Started Courtine:"+Time.deltaTime);
        yield return new WaitForSecondsRealtime(5);
        Debug.Log("Ended courtine time:"+Time.deltaTime);
    }

}
