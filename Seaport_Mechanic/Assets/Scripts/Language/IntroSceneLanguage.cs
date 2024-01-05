using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class IntroSceneLanguage : MonoBehaviour
{
    public TMP_Text secondTip;
    public TMP_Text BossTip;

    public InputActionProperty leftTrigger;
    public InputActionProperty rightTrigger;
    public InputActionProperty leftTeleport;
    public InputActionProperty rightTeleport;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {       
        BossTip.text = LanguageManager.Instance.GetText(LanguageManager.TextID.LockerRoomBoss);
       
        secondTip.text = LanguageManager.Instance.GetText(LanguageManager.TextID.SecondTipText);
        if (leftTeleport.action.IsPressed() || rightTeleport.action.IsPressed())
        {
            secondTip.gameObject.transform.parent.gameObject.SetActive(false);
        }

    }
}
