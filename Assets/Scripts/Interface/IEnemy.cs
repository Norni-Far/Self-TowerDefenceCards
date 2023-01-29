using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy
{
    public int Health { get; set; }
    public bool SetDamage(int damage);
    public void DeadThis();
    public GameObject GetGameObject();
}
