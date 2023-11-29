using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IntroSceneLanguage : MonoBehaviour
{

    public TMP_Text settingsText;
    public TMP_Text languageText;
    public TMP_Text firstObjectText;
    public TMP_Text secondObject;
    public TMP_Text thirdObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        settingsText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.SettingsText);
        languageText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.LanguageText);
        firstObjectText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.EquipmentText);
        secondObject.text = LanguageManager.Instance.GetText(LanguageManager.TextID.EquipmentText);
        thirdObject.text = LanguageManager.Instance.GetText(LanguageManager.TextID.EquipmentText);
    }
}
