using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveFunctionScript : MonoBehaviour
{
    //Variables for testing
    public Transform testTile1,testTile2,TestTile3;
    public Vector3[] testWayPoints;
    private Vector3 testVector1, testVector2, testVector3;
    void Start()
    {
        testVector1.x = transform.position.x; testVector1.y = transform.position.y + 1; testVector1.z = transform.position.z;
        testVector2.x = testTile1.position.x; testVector2.y = transform.position.y;     testVector2.z = testTile1.transform.position.z;
        testVector3.x = testTile1.position.x; testVector3.y = 0.5f;testVector3.z= testTile1.transform.position.z;

        testWayPoints = new Vector3[] {testVector1,testVector2,testVector3};
       
        StartMovingFunction(testTile1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Function to work for moving.Uses parameters nexttile and dice result
    public void StartMovingFunction(Transform nextTile)
    {
        transform.DOPath(testWayPoints,2);
       
      
    }
}
