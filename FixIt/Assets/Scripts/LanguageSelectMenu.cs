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
        switch (GameManager.Instance.chosenLanguage)
        {
            case GameManager.language.English:
                {
                    text.text = "choose your language";
                    break;
                }
            case GameManager.language.Dutch:
                {
                    text.text = "kies je taal";
                    break;
                }
            case GameManager.language.Arabian:
                {
                    text.text = "kies je taal";
                    break;
                }
            default:
                {
                    break;
                }
        }        
    }
}
