using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITower
{

    public GameObject GetGameObject();

    public bool SetBonus(IUpgratePowerBonus bonus);

}
