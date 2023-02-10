using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider), typeof(Rigidbody))]
public abstract class Tower : MonoBehaviour, ITower
{
    public List<IEnemy> seesEnemyes = new List<IEnemy>();

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IEnemy enemy))
        {
            seesEnemyes.Add(enemy);
        }
    }

    public virtual void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out IEnemy enemy))
        {
            seesEnemyes.Remove(enemy);
        }
    }

    public abstract bool SetBonus(IUpgratePowerBonus bonus);
    public abstract void Fire(IEnemy enemy);
    public abstract void ShowFire(Transform target);
    public GameObject GetGameObject() => gameObject;

}
