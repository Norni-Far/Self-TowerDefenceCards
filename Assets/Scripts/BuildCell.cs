using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class BuildCell : MonoBehaviour, IBuildCell
{
    [SerializeField] private Transform placeForSetTower;

    private void Start()
    {

    }

    public bool SetCardsInPos(ICards card)
    {
        // signal for spawn base )(send id)

        if (placeForSetTower.childCount > 0) return false;

        switch (card.SelfMode)
        {
            case (int)ICards.ModeCard.ITower:
                if (SetTowerOnPlace(card.IdCards)) return true;
                break;
            case (int)ICards.ModeCard.IBonusTowers:
                if (SetBonusOnTower(card.IdCards)) return true;
                break;
        }

        return false;
    }

    private bool SetTowerOnPlace(int idTower)
    {
        try
        {
            Spawner.instance.SetSpawnObject(TowerBase.instance.GetTower(idTower), placeForSetTower.position);
            return true;
        }
        catch (System.Exception ex)
        {
            throw new System.Exception("can't SetTowerOnPlace = " + ex.Message);
            return false;
        }

    }

    private bool SetBonusOnTower(int idBonus)
    {
        throw new System.Exception("We haven't bonus");

        return true;
    }

}
