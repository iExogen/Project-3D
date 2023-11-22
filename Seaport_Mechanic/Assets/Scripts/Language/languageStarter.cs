using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class languageStarter : MonoBehaviour
{
    public enum LanguageFlag
    {
        belgian,
        american,
    }
    private XRSimpleInteractable interactable;
    public TMP_Text languageText;
    public Texture belgianFlag;
    public Texture AmericanFlag;
    public Texture ArabFlag;
    public RawImage flagImage;
    private Texture[] flags = new Texture[3];

    // Start is called before the first frame update
    void Start()
    {
        flags[0] = AmericanFlag;
        flags[1] = belgianFlag;
        interactable = GetComponent<XRSimpleInteractable>();
        languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
        interactable.hoverEntered.AddListener(Follow);
    }
    public void Follow(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRPokeInteractor)
        {
            if (interactable.gameObject.tag == "NextLanguage")
            {
                if (LanguageManager.Instance.chosenLanguage == LanguageManager.Language.Nederlands)
                {
                    LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
                    languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
                }
                else
                {
                    LanguageManager.Instance.chosenLanguage++;
                    languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
                }
                flagImage.texture = flags[(int)LanguageManager.Instance.chosenLanguage];
            }
            else if(interactable.gameObject.tag == "PreviousLanguage")
            {
                if(LanguageManager.Instance.chosenLanguage == LanguageManager.Language.English)
                {
                    LanguageManager.Instance.chosenLanguage = LanguageManager.Language.Nederlands;
                    languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
                }
                else
                {
                    LanguageManager.Instance.chosenLanguage--;
                    languageText.text = LanguageManager.Instance.chosenLanguage.ToString();
                }
                flagImage.texture = flags[(int)LanguageManager.Instance.chosenLanguage];
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
