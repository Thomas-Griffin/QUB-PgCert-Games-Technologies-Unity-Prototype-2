using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // level bounds for objects
    private const float TopBound = 30;
    private const float LowerBound = -10;


    // Update is called once per frame
    void Update()
    {
        // Destroy the object if it goes out of bounds
        if (transform.position.z > TopBound)
        {
            // the object is destroyed
            Destroy(gameObject);
        }
        // if the object goes below the lower bound
        else if (transform.position.z < LowerBound)
        {
            // log "Game Over!"
            Debug.Log("Game Over!");

            // the object is destroyed
            Destroy(gameObject);
        }
    }
}