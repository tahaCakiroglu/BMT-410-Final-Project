using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{

    [SerializeField] GameObject[] waypoints;

    public int currentWayPointIndex = 0;

    [SerializeField] float speed = 1f; // Unity edit�rde h�z ayarlicaz.
    void Update()
    {
        if (Vector3.Distance( transform.position, waypoints[currentWayPointIndex].transform.position) < .1f)
        {
            currentWayPointIndex++;
            if ( currentWayPointIndex >= waypoints.Length)
            {
                currentWayPointIndex = 0;
            }
        }
        // Vector3.MoveForwards : Ge�erli ve hedef taraf�ndan belirtilen noktalar aras�nda konum ayarlayarak
        // fonksiyona s�rekli girip konumu ve maxDistanceDelta ayarlan�r.
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position, speed * Time.deltaTime);
    }
}
