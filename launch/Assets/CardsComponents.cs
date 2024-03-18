using UnityEngine;
using UnityEngine.UI; // Import the UI namespace


public class CardsComponents : MonoBehaviour
{
    public GameObject cards;
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject components;
    public GameObject components1;
    public GameObject components2;
    public GameObject components3;
    public GameObject components4;
    public GameObject components5;
    public GameObject components6;
    //public Button myButton;

    void Start()
    {
        //myButton.onClick.AddListener(OnButtonClick);
        components.SetActive(false);
        components1.SetActive(false);
        components2.SetActive(false);
        components3.SetActive(false);
        components4.SetActive(false);
        components5.SetActive(false);
        components6.SetActive(false);
    }

    public void showComponets()
    {
        Debug.Log("Button Clicked!");
        components.SetActive(true);
        components1.SetActive(true);
        components2.SetActive(true);
        components3.SetActive(true);
        components4.SetActive(true);
        components5.SetActive(true);
        components6.SetActive(true);
        cards.SetActive(false);
        card1.SetActive(false);
        card2.SetActive(false);
        card3.SetActive(false);
    }
}

