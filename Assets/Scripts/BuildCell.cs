using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class BuildCell : MonoBehaviour, IBuildCell
{


    public void SetCardsInPos(ICards card)
    {
       // signal for spawn base )(send id)
    }
}
