using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

}

[CreateAssetMenu(fileName = "Model for UpgateTower")]
public class UpgrateModel : ScriptableObject
{
    [SerializeField] internal int power;
    [SerializeField] internal PriceType Price;
}

enum PriceType
{
    coin5 = 5,
    coin10 = 10,
    coin50 = 50
}
