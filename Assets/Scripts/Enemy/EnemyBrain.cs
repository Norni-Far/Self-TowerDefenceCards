using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBrain : MonoBehaviour
{
    [SerializeField] private EnemyBase enemyBase;

    [SerializeField] private bool startSpawn;
    [SerializeField] private Transform positionCreate;

    [Header("Characteristics")]
    [SerializeField] private float timeToCreate;

    private void Start()
    {
        StartCoroutine(CreateEnemyes());
    }

    [SerializeField] private List<Transform> pathForEnemy = new List<Transform>();
    public void SetRoadForEnemy(List<Transform> path)
    {
        pathForEnemy = path;
    }

    private IEnumerator CreateEnemyes()
    {
        yield return new WaitUntil(() => startSpawn);

        print(1);

        while (true)
        {
            yield return new WaitForSeconds(timeToCreate);

            print(2);

            IEnemy enemy = Spawner.instance.SetSpawnObject(enemyBase.GetEnemyFromList(0), positionCreate.position);

            SetSettingsForEnemy(enemy);
        }
    }

    private void SetSettingsForEnemy(IEnemy enemy)
    {
        enemy.GetGameObject().GetComponent<CreateLineForMovement>().pathElements = pathForEnemy.ToArray();
    }

}
