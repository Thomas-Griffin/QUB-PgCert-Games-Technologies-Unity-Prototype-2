using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;


    // Update is called once per frame
    void Update()
    {
        // Destroy the object if it goes out of bounds
        if (transform.position.z > topBound || transform.position.z < lowerBound)
        {
            // the object is destroyed
            Destroy(gameObject);
        }
    }
}