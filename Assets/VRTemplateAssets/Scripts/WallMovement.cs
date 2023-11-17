using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float movementSpeed = 5f; // Adjust the speed as needed

    void Update()
    {
        // Get input values for movement
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the new position based on input and speed
        Vector3 newPosition = transform.position +
            new Vector3(0f, verticalInput, 0f) * movementSpeed * Time.deltaTime;

        // Update the position of the wall
        transform.position = newPosition;
    }
}
