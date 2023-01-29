using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instance;
    private void Awake()
    {
        instance = this;
    }

    public IEnemy SetSpawnObject(IEnemy enemy, Vector3 positionOfSpawn)
    {
        IEnemy newEnemy = Instantiate(enemy.GetGameObject(), positionOfSpawn, new Quaternion(0, 0, 0, 0), null).GetComponent<IEnemy>();

        return newEnemy;
    }

    public ITower SetSpawnObject(ITower tower, Vector3 positionOfSpawn)
    {
        ITower newTower = Instantiate(tower.GetGameObject(), positionOfSpawn, new Quaternion(0, 0, 0, 0), null).GetComponent<ITower>();

        return newTower;
    }

}
