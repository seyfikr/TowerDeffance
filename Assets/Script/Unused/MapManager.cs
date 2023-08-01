using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public static MapManager instance;
    public Transform Finish;
    public Transform Finish2;

    private void Awake()
    {
        instance = this;
    }
}
