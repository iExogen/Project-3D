using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{

    public TMP_Text startButton;
    public TMP_Text endButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.text = LanguageManager.Instance.GetText(LanguageManager.TextID.StartButton);
        endButton.text = LanguageManager.Instance.GetText(LanguageManager.TextID.EndButton);
    }
}
