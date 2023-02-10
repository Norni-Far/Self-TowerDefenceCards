using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataModel : MonoBehaviour
{
    public DataModel instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] private static List<ScriptableObject> models = new List<ScriptableObject>();
}
