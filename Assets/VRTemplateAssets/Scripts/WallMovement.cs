using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float speed = 2f; // Adjust the speed as needed
    public float squareSize = 10f; // Adjust the size of the square as needed

    private float timer;

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Calculate the new position based on square motion
        float x = Mathf.PingPong(timer * speed, squareSize) - squareSize / 2f;
        float y = Mathf.PingPong(timer * speed, squareSize) - squareSize / 2f;

        // Update the position of the wall
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
