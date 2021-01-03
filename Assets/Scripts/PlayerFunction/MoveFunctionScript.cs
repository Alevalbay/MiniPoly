using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveFunctionScript : MonoBehaviour
{
    //Variables for testing
    public Transform testTile1,testTile2,TestTile3;
    public Vector3[] testWayPoints;
    public Vector3[] wayPointsToNextTile;
    private Vector3 testVector1, testVector2, testVector3;
    private Vector3 goesUpVector, goesForwardVector, goesDownVector;

    private float timer;
    void Start()
    {
      /*  testVector1.x = transform.position.x; testVector1.y = transform.position.y + 1; testVector1.z = transform.position.z;
        testVector2.x = testTile1.position.x; testVector2.y = transform.position.y;     testVector2.z = testTile1.transform.position.z;
        testVector3.x = testTile1.position.x; testVector3.y = 0.5f;testVector3.z= testTile1.transform.position.z;

        testWayPoints = new Vector3[] { testVector1, testVector2, testVector3 };
        */
    }

    // Update is called once per frame
    void Update()
    {
    }


    //Function to work for moving.Uses parameters nexttile and dice result
    public void StartMovingFunction(Transform nextTile)
    {
        //We need 3 waypoint first object will move up,then goes forward next tile,last one move down
        MakingWayPoints(nextTile);

        //Dotween asset function makes moving easy
        transform.DOPath(wayPointsToNextTile,2);
  
    }

    //We need 3 waypoint first object will move up,then goes forward next tile,last one move down
    //This function converts tranform to Vector3
    public void MakingWayPoints(Transform nextTile)
    { 
        goesUpVector.x      = transform.position.x ; goesUpVector.y      = transform.position.y + 1.5f ; goesUpVector.z      = transform.position.z;
        goesForwardVector.x = nextTile.position.x  ; goesForwardVector.y = transform.position.y        ; goesForwardVector.z = nextTile.transform.position.z;
        goesDownVector.x    = nextTile.position.x  ; goesDownVector.y    = 0.5f                        ; goesDownVector.z    = nextTile.transform.position.z;

        wayPointsToNextTile = new Vector3[] { goesUpVector, goesForwardVector, goesDownVector };

    }

  



}
