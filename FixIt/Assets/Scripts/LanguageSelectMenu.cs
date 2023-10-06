using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageSelectMenu : MonoBehaviour
{
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "test";
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.language == "english")
        {
            text.text = "choose your language";
        }
        else if (GameManager.Instance.language == "dutch")
        {
            text.text = "kies je taal";
        }
    }
}
