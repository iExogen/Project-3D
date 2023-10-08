using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditorInternal;
using UnityEngine;
using Random = System.Random;

public class GameManager : Singleton<GameManager>
{
    public int language = 1;
    public int totalRepairs;

     private void Start()
    {
        Random random = new Random();
        totalRepairs = random.Next(4, 6);
    }

    private void Update()
    {
        
    }
}