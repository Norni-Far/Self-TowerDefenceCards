using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public abstract class Enemy : MonoBehaviour, IEnemy
{
    [SerializeField] private MoveTowardsForLinePosition moveTowardsForLine;

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            health = value;
        }
    }
    public Animator animatorEnemy;

    public bool SetDamage(int damage)
    {
        Health -= damage;

        if (health > 0)
        {
            return true;
        }
        else
        {
            DeadThis();
            return false;
        }

    }

    public void DeadThis()
    {
        AnimationEnemy.animationEnemy.SetDeadEnemy(animatorEnemy);
        moveTowardsForLine.enabled = false;
    }

    public GameObject GetGameObject() => gameObject;
}
