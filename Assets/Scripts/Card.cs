using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameObject CardOpen;
    public GameObject CardClose;
    public GameManager gameManager;

    private bool isClosed = true;

    public void CardOnClick()
    {
        if (isClosed == true)
        {
            OpenCard();
            int pos = int.Parse(name);
            gameManager.PlayCard(pos, this);
        }
    }

    public void OpenCard()
    {
        CardClose.SetActive(false);
        CardOpen.SetActive(true);
        isClosed = false;
    }

    public void CloseCard()
    {
        CardClose.SetActive(true);
        CardOpen.SetActive(false);
        isClosed = true;
    }
}
