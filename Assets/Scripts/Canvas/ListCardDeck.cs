using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ListCardDeck : MonoBehaviour
{
    [SerializeField] private Transform selectFolder;
    [SerializeField] private BuildTower buildTower;
    List<GameObject> listCardDeck = new List<GameObject>();
    [SerializeField] private GameObject[] arrayAllCard = new GameObject[20];
    [SerializeField] private Transform deck;
    [SerializeField] private int numberCard;
    public void AddCard(int numberCard)
    {
        GameObject card = Instantiate(arrayAllCard[numberCard], deck);
        Card cardScr = card.GetComponent<Card>();
        cardScr.listCardDeck = this;
        cardScr.buildTower = buildTower;
        listCardDeck.Add(card);
    }
    public void ReturnToDeck(GameObject card)
    {
        card.transform.SetParent(deck);
    }
    public void DestrouCard(int numberCard)
    {
        listCardDeck.Remove(arrayAllCard[numberCard]);
    }
    public void SelectCard(GameObject card)
    {
        card.transform.SetParent(selectFolder);
    }
    private void Start()
    {
        AddCard(0);
        AddCard(0);
        AddCard(0);
    }
}
