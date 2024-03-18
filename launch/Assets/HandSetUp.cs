using UnityEngine;

public class HandSetUp : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject rightHand;
    //public GameObject handmodel;
    public Material whiteMaterial;

    //public void Start()
    //{
    //    // Change the material of the hand mesh renderer to white
    //    var leftHandMeshRenderer = leftHand.GetComponentInChildren<SkinnedMeshRenderer>();
    //    var rightHandMeshRenderer = rightHand.GetComponentInChildren<SkinnedMeshRenderer>();

    //    if (leftHandMeshRenderer != null)
    //        leftHandMeshRenderer.material = whiteMaterial;

    //    if (rightHandMeshRenderer != null)
    //        rightHandMeshRenderer.material = whiteMaterial;
    //}
    //Collider collision
    public void ChangeHandColor()
    {
        // Check for collision with a specific object
        //if (collision.gameObject.tag == "lefthand" || collision.gameObject.tag == "righthand")
        //{
            
        var leftHandMeshRenderer = leftHand.GetComponentInChildren<SkinnedMeshRenderer>();
        var rightHandMeshRenderer = rightHand.GetComponentInChildren<SkinnedMeshRenderer>();

        if (leftHandMeshRenderer != null)
            leftHandMeshRenderer.material = whiteMaterial;

        if (rightHandMeshRenderer != null)
            rightHandMeshRenderer.material = whiteMaterial;
        //handmodel.SetActive(false);
        //}
    }
}
