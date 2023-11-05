using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class languageStarter : MonoBehaviour
{
    private XRSimpleInteractable interactable;
    public TMP_Text languageText;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
        interactable.selectEntered.AddListener(Select);
    }
    public void Select(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRRayInteractor)
        {
            if (interactable.gameObject.tag == "NextLanguage")
            {
                if (LanguageManager.Instance.chosenLanguage == LanguageManager.Language.Arabic)
                {
                    LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
                    languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
                }
                else
                {
                    LanguageManager.Instance.chosenLanguage++;
                    languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
                }
            }
            else if(interactable.gameObject.tag == "PreviousLanguage")
            {
                if(LanguageManager.Instance.chosenLanguage == LanguageManager.Language.English)
                {
                    LanguageManager.Instance.chosenLanguage = LanguageManager.Language.Arabic;
                    languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
                }
                else
                {
                    LanguageManager.Instance.chosenLanguage--;
                    languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
