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
    public enum language
    {
        English,
        Dutch,
        Arabian
    }
    public language chosenLanguage;
    public int totalRepairs;
    public int repairsDone = 0;
    string[,] dictionary = new string[0,2];
     private void Start()
    {
        Random random = new Random();
        totalRepairs = random.Next(4, 6);
    }

    private void Update()
    {
        
    }
}