using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class languageStarter : MonoBehaviour
{
    private enum LanguageFlag
    {
        belgian,
        american,
    }
    public Collider UkArican;
    public Collider Belgerland;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            UkArican.transform.gameObject.SetActive(false);
        }
    }
    void Update()
    {
        
    }
}
