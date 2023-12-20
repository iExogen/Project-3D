using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = System.Random;

public class GameManager : Singleton<GameManager>
{
    public int totalRepairs = 3;
    public int repairsDone = 0;
    public int screwsRemoved = 0;
    public int screwsFixed = 0;
    public int finishPlace = 1;
    public int equipedItems=0;

    private void Start()
    {
    }

}