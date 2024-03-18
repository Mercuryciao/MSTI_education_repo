using UnityEngine;

public class HideOnCollision : MonoBehaviour
{
    public GameObject showQSFP; // Assign this in the inspector
    public GameObject pickQSFP;
    public GameObject header3;
    public GameObject final;
    public GameObject afterweargloves;
    public GameObject pinkframe;
    public GameObject interactable;



    void Start()
    {
        // Hide Model_QSFP initially
        showQSFP.SetActive(false);
        header3.SetActive(false);
        final.SetActive(false);
        interactable.SetActive(false);


    }

    void OnTriggerEnter(Collider collision)
    {
        // Check for collision with a specific object
        if (collision.gameObject.tag == "pulltab" || collision.gameObject.tag == "cube")
        {
            // Show Model_QSFP
            showQSFP.SetActive(true);
            pickQSFP.SetActive(false);
            header3.SetActive(true);
            final.SetActive(true);
            afterweargloves.SetActive(false);
            pinkframe.SetActive(false);
            interactable.SetActive(true);

        }
    }
}


//using UnityEngine;

//public class HideOnCollision : MonoBehaviour
//{
//    public GameObject showQSFP; // The actual model to show
//    public GameObject showQSFProxy; // The proxy object for collision detection


//    void Start()
//    {
//        // Hide the show_QSFP model initially
//        showQSFP.SetActive(false);
//    }

//    void OnCollisionEnter(Collision collision)
//    {
//        // Check if the collision is with the proxy of show_QSFP
//        if (collision.gameObject == Cube)
//        {
//            // Make the show_QSFP model visible
//            showQSFP.SetActive(true);
//        }
//    }
//}