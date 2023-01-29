using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabEnemyes = new List<GameObject>();
    

    public IEnemy GetEnemyFromList(int id)
    {
        if (id >= prefabEnemyes.Count) throw new System.Exception($"list of enemy is haven't this id = {id}");

        return prefabEnemyes[id].GetComponent<IEnemy>();
    }
}
