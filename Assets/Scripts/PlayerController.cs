using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Player movement variables
    public float horizontalInput;
    public float playerSpeed = 10.0f;
    public int playerMovementBoundary = 10;

    // Projectile variables
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10) // left boundary check
        {
            // snap player back to the boundary
            transform.position = new Vector3(-playerMovementBoundary, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 10) // right boundary check
        {
            // snap player back to the boundary
            transform.position = new Vector3(playerMovementBoundary, transform.position.y, transform.position.z);
        }

        // Get the horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the player left and right
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * playerSpeed));
    }
}