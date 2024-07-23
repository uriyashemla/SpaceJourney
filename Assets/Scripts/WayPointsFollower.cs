using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointsFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    private int currentWayPointIndex = 0;
    private bool isForward = true;

    [SerializeField] private float speed = 2f;
    void Update()
    {        
        if (Vector2.Distance(wayPoints[currentWayPointIndex].transform.position, transform.position) < 0.1f)
        {
            if (isForward)
            {
                currentWayPointIndex++;
                if (currentWayPointIndex >= wayPoints.Length)
                {
                    currentWayPointIndex = wayPoints.Length - 2;
                    isForward = false;
                }
            }
            else
            {
                currentWayPointIndex--;
                if (currentWayPointIndex < 0)
                {
                    currentWayPointIndex = 1;
                    isForward = true;
                }
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPointIndex].transform.position, Time.deltaTime * speed);
    }

}
