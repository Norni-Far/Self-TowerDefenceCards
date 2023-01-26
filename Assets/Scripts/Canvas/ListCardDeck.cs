using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ListCardDeck : MonoBehaviour
{
    [SerializeField] private Transform selectFolder;
    List<GameObject> listCardDeck = new List<GameObject>();
    [SerializeField] private GameObject[] arrayAllCard = new GameObject[20];
    [SerializeField] private Transform deck;
    [SerializeField] private int numberCard;
    public void AddCard(int numberCard)
    {
        GameObject card = Instantiate(arrayAllCard[numberCard], deck);
        card.GetComponent<Card>().listCardDeck = this;
        listCardDeck.Add(card);
    }
    public void DestrouCard(int numberCard)
    {
        listCardDeck.Remove(arrayAllCard[numberCard]);
    }
    public void SelectCard(GameObject card)
    {
        card.transform.parent = selectFolder.transform;
    }
    private void Start()
    {
        AddCard(0);
    }
}
