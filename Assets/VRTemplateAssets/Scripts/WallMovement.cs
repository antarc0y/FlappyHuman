using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float movementSpeed = 5f; // Adjust the speed as needed
    public float boundarySize = 20f; // Adjust the size of the boundary as needed

    void Update()
    {
        // Get input values for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the new position based on input and speed
        Vector3 newPosition = transform.position +
            new Vector3(horizontalInput, verticalInput, 0f) * movementSpeed * Time.deltaTime;

        // Clamp the position to stay within the square boundary
        newPosition.x = Mathf.Clamp(newPosition.x, -boundarySize, boundarySize);
        newPosition.y = Mathf.Clamp(newPosition.y, -boundarySize, boundarySize);

        // Update the position of the wall
        transform.position = newPosition;
    }
}
