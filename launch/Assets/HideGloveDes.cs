using UnityEngine;

public class HideGloveDes : MonoBehaviour
{
    public GameObject WearESDGlovesdes;
    public GameObject AfterWearGloves;
    public GameObject Interactables;
    public GameObject header;
    public GameObject header2;
    public GameObject QSFP_pulltab;
    public GameObject pinkframe;

    public void Start()
    {
        // Hide Model_QSFP initially
        AfterWearGloves.SetActive(false);
        header2.SetActive(false);
        QSFP_pulltab.SetActive(false);
        pinkframe.SetActive(false);
    }

    public void Hidedes()
    {
        // Show Model_QSFP
        AfterWearGloves.SetActive(true);
        WearESDGlovesdes.SetActive(false);
        Interactables.SetActive(false);
        header.SetActive(false);
        header2.SetActive(true);
        QSFP_pulltab.SetActive(true);
        pinkframe.SetActive(true);
    }
}