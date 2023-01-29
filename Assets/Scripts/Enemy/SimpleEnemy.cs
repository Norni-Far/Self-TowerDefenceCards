using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : Enemy
{
    [SerializeField] private int health;

    private void Awake()
    {
        Health = health;
    }


}
