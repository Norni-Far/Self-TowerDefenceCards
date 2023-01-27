using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider), typeof(Rigidbody))]
public abstract class Tower : MonoBehaviour
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

}
