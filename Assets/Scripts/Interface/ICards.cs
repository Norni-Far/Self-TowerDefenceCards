using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICards
{
    public enum ModeCard
    {
        ITower,
        IBonusTowers
    }

    public int IdCards { get; set; }
    public ModeCard selfMode { get; set; }


}
