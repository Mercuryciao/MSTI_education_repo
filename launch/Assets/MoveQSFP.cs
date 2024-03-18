//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnabledOrDisabled : MonoBehaviour
//{
//    public GameObject pic;

//    public void Trigger()
//    {
//        if (pic.activeInHierarchy == false)
//        {
//            pic.SetActive(true);

//        }
//        else
//        {
//            pic.SetActive(false);
//        }
//    }
//}
//using UnityEngine;

//public class ChangeColorOnCollision : MonoBehaviour
//{
//    public Color colorOnCollision = Color.red; // Set the color you want

//    void OnCollisionEnter(Collision collision)
//    {
//        if (collision.gameObject.tag == "screwdriver")
//        {
//            Renderer renderer = GetComponent<Renderer>();
//                if (GetComponent<Renderer>() != null)
//                {
//                    GetComponent<Renderer>().material.color = colorOnCollision;
//                }
//        }
//    }
//}

using UnityEngine;

public class MoveQSFP : MonoBehaviour
{
    public GameObject qsfpModel; // Assign your QSFP model here
    public float placementThreshold = 0.05f; // Threshold for placement accuracy, adjust as needed

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == qsfpModel)
        {
            // QSFP model has entered the zone
            CheckPlacement(other);
        }
    }

    private void CheckPlacement(Collider qsfpCollider)
    {
        // Calculate the difference in position between the QSFP model and the target zone
        Vector3 positionDifference = transform.position - qsfpCollider.transform.position;

        // Check if the QSFP model is placed within the allowed threshold
        if (positionDifference.magnitude <= placementThreshold)
        {
            OnSuccessfulPlacement();
        }
        else
        {
            Debug.Log("QSFP model is not in the correct position. Try again.");
        }
    }

    private void OnSuccessfulPlacement()
    {
        // Trigger the successful event
        Debug.Log("QSFP model placed successfully!");

        // Add more actions as needed
    }
}
