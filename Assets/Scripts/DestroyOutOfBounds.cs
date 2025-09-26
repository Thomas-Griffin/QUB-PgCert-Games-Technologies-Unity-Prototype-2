using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float TopBound = 30;
    private const float LowerBound = -10;


    // Update is called once per frame
    void Update()
    {
        // Destroy the object if it goes out of bounds
        if (transform.position.z is > TopBound or < LowerBound)
        {
            // the object is destroyed
            Destroy(gameObject);
        }
    }
}