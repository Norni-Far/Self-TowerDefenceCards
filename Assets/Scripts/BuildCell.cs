using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class BuildCell : MonoBehaviour, IBuildCell
{
    [SerializeField] private Spawner spawner;

    [SerializeField] private Transform placeForSetTower;

    private void Start()
    {
       
    }

    public bool SetCardsInPos(ICards card)
    {
        // signal for spawn base )(send id)

        switch (card.selfMode)
        {
            case ICards.ModeCard.ITower:
                if (SetTowerOnPlace(card.IdCards)) return true;
                break;
            case ICards.ModeCard.IBonusTowers:
                if (SetBonusOnTower(card.IdCards)) return true;
                break;
        }

        return false;
    }

    private bool SetTowerOnPlace(int idTower)
    {
        try
        {
            spawner.SetSpawnObject(TowerBase.instance.GetTower(idTower), placeForSetTower);
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


        return true;
    }

}
