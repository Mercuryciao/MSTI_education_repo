using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision object is the sphere
        if (collision.collider.CompareTag("screwdriver"))
        {
            // Change the color of the cube
            GetComponent<Renderer>().material.color = Color.red; // or any color you prefer
        }
    }
}