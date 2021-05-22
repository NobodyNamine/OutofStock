using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLogic1 : MonoBehaviour
{
    public Button buyButton;
    public Text Timer;
    Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
        buttonText = buyButton.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (int.Parse(Timer.text) <= 5 && int.Parse(Timer.text) > 4)
        {
            buyButton.interactable = true;
            buttonText.text = "IN STOCK!";
            buyButton.GetComponentInChildren<Image>().color = new Color(0,250,0);
        }
        if ( int.Parse(Timer.text) < 5)
        {
            buyButton.interactable = false;
            buttonText.text = "OUT OF STOCK";
            buyButton.GetComponentInChildren<Image>().color = new Color(255, 172, 185);
        }
    }
}
