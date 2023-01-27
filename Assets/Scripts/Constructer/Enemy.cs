using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public abstract class Enemy : MonoBehaviour
{

    private int health;
    public int Health { get { return health; } private set { health = value; } }


    public void SetDamage(int damage) => Health -= damage;

    public virtual void DeadThis()
    {

    }
}
