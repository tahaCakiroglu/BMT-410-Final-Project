using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{

    [SerializeField] GameObject[] waypoints;

    public int currentWayPointIndex = 0;

    [SerializeField] float speed = 1f; // Unity editörde hýz ayarlicaz.
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
        // Vector3.MoveForwards : Geçerli ve hedef tarafýndan belirtilen noktalar arasýnda konum ayarlayarak
        // fonksiyona sürekli girip konumu ve maxDistanceDelta ayarlanýr.
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position, speed * Time.deltaTime);
    }
}
