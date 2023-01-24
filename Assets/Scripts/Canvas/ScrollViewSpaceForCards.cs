using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewSpaceForCards : MonoBehaviour
{
    [SerializeField] private int maxCards;
    private int numberOfCards = 0;
    [SerializeField] private GridLayoutGroup content;
    private void UpdateSpaceForCards()
    {

    }
    public bool AddCard(GameObject newCard)
    {
        if (numberOfCards < maxCards)
        {
            numberOfCards++;
            UpdateSpaceForCards();
            return true;
        }
        else
            return false;
        
    }
    public void RemoveCard()
    {
        numberOfCards--;
        UpdateSpaceForCards();
    }
}
