using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ElJeffe : MonoBehaviour
{

    public GameObject position2;
    public GameObject player;
    private bool firstPosition = false;

    public TMP_Text tutorialText;
    // Start is called before the first frame update
    void Start()
    {
        tutorialText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.GarageBoss1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,player.transform.position) < 5f && !firstPosition)
        {
            firstPosition = true;
        }
        else if(Vector3.Distance(transform.position,player.transform.position) > 5f && firstPosition)
        {
            transform.position = position2.transform.position;
            transform.rotation = position2.transform.rotation;
            tutorialText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.GarageBoss2);
        }
    }
}
