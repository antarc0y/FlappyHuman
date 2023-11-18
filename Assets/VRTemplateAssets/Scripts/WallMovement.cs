using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float speed = 0.5f; // Adjust the speed as needed
    public float squareSize = 10f; // Adjust the size of the square as needed

    private Vector3[] waypoints;
    private int currentWaypointIndex;

    void Start()
    {
        // Define waypoints around the perimeter of the square
        waypoints = new Vector3[]
        {
            new Vector3(squareSize / 2f, squareSize / 2f, 0f),
            new Vector3(squareSize / 2f, -squareSize / 2f, 0f),
            new Vector3(-squareSize / 2f, -squareSize / 2f, 0f),
            new Vector3(-squareSize / 2f, squareSize / 2f, 0f)
        };

        // Set the initial position to the first waypoint
        transform.position = waypoints[0];
        currentWaypointIndex = 1;
    }

    void Update()
    {
        // Move towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex], speed * Time.deltaTime);

        // Check if the wall has reached the current waypoint
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex]) < 0.01f)
        {
            // Move to the next waypoint
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
