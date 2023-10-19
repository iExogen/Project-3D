using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = System.Random;

public class GameManager : Singleton<GameManager>
{
    public int totalRepairs = 5;
    public int repairsDone = 0;
<<<<<<< HEAD
    public int RepairsNeeded;
    public float npcRepairs=0;
=======
    public int screwsRemoved = 0;
    public int screwsFixed = 0;
>>>>>>> Drill-Repair
     private void Start()
    {
    }
    private void Update()
    {
        RepairsNeeded = totalRepairs - repairsDone;
    }
}