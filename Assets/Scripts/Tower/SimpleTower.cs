using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTower : Tower
{
    [Header("Gun")]
    [SerializeField] private Transform gun;
    [SerializeField] private ParticleSystem showFire;

    [Header("Characteristics")]
    [SerializeField] private float timeToReload;
    [SerializeField] private int damage;



    private float currentTime;
    private void FixedUpdate()
    {
        if (timeToReload > currentTime)
        {
            currentTime += Time.deltaTime;
        }

        if (seesEnemyes.Count > 0)
        {
            ShowFire(seesEnemyes[0].GetGameObject().transform);

            if (timeToReload <= currentTime)
            {
                Fire(seesEnemyes[0]);
                currentTime = 0;
            }
        }
    }

    public override void Fire(IEnemy enemy = null)
    {
        if (enemy == null) return;

        if (!enemy.SetDamage(damage)) seesEnemyes.Remove(enemy);
        showFire.Play();
    }

    public override void ShowFire(Transform target)
    {
        gun.transform.LookAt(target.transform.localPosition);
    }

}
