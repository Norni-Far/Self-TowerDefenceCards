using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterCards : MonoBehaviour
{
    [Header("�������� ���� � �� id")]
    [SerializeField] private List<ModeCards> cardsOfRace = new List<ModeCards>();
}

[Serializable]
public class ModeCards
{
    [SerializeField] public string nameOfRace;

    [Header("Tower �����")]
    [SerializeField] public List<GameObject> towerCards = new List<GameObject>();

    [Header("����� �����")]
    [SerializeField] public List<GameObject> bonusCards = new List<GameObject>();
}