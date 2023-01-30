using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICards
{
    public enum ModeCard
    {
        ITower = 0,
        IBonusTowers = 1
    }

    public int IdCards { get; set; }
    public int SelfMode { get; set; }
  

}
