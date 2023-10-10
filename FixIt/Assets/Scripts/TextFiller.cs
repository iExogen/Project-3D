using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFiller : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text introText;
    private string introTextString;
    void Start()
    {
        introTextString = LanguageManager.Instance.GetText(LanguageManager.TextID.IntroText);
        introText.text = introTextString; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
