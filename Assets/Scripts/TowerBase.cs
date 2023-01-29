using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabTowers = new List<GameObject>();

    public static TowerBase instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    public ITower GetTower(int idTower)
    {
        if (idTower < 0) idTower = 0;
        else if (idTower >= prefabTowers.Count) idTower = prefabTowers.Count - 1;

        return prefabTowers[idTower].GetComponent<ITower>();
    }
}
