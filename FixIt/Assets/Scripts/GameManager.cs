using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public string language = "english";
   public GameObject managerObject = new GameObject();
   private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance is null)
                Debug.LogError("Game Manager is Null");
            managerObject.name = "gameManager";
            DontDestroyOnLoad(managerObject);
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }
}