using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = System.Random;

public class GameManager : Singleton<GameManager>
{
    public int totalRepairs = 3;
    public int repairsDone = 0;
    public int screwsRemoved = 0;
    public int screwsFixed = 0;
    public int finishPlace = 1;
     private void Start()
    {
    }
}