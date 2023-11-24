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
    public enum LanguageFlag
    {
        belgian,
        american,
    }
    private XRSimpleInteractable interactable;
    public TMP_Text languageText;
    public Texture belgianFlag;
    public Texture AmericanFlag;
    public RawImage flagImage;
    public TMP_Text next;
    public TMP_Text previous;
    public TMP_Text ok;
    public TMP_Text settings;
    private Color originalColor;
    private Texture[] flags = new Texture[3];

    // Start is called before the first frame update
    void Start()
    {
        originalColor = settings.color;
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
            if (interactable.gameObject.name == "Right")
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
                languageText.color = originalColor;
                previous.color = originalColor;
                next.color = originalColor;
                ok.color = originalColor;
                settings.color = originalColor;
            }
            else if(interactable.gameObject.name == "Left")
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
                languageText.color = originalColor;
                previous.color = originalColor;
                next.color = originalColor;
                ok.color = originalColor;
                settings.color = originalColor;
            }
            else if(interactable.gameObject.name == "Ok")
            {
                languageText.color = Color.green;
                previous.color = Color.green;
                next.color = Color.green;
                ok.color = Color.green;
                settings.color = Color.green;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
