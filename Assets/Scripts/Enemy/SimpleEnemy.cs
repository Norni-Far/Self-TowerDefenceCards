using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : Enemy
{
    [SerializeField] private int startHealth;

    private void Awake()
    {
        Health = startHealth;
    }


}
