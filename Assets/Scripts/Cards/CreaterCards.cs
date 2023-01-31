using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterCards : MonoBehaviour
{
    [Header("Карточки расс и их id")]
    [SerializeField] private List<ModeCards> cardsOfRace = new List<ModeCards>();
}

[Serializable]
public class ModeCards
{
    [SerializeField] public string nameOfRace;

    [Header("Tower карты")]
    [SerializeField] public List<GameObject> towerCards = new List<GameObject>();

    [Header("Бонус карты")]
    [SerializeField] public List<GameObject> bonusCards = new List<GameObject>();
}