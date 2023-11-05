using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class languageStarter : MonoBehaviour
{
    private XRSimpleInteractable interactable;
    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<XRSimpleInteractable>();

        interactable.selectEntered.AddListener(Select);
    }
    public void Select(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRRayInteractor)
        {
            if(interactable.gameObject.tag == "English")
            {
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
            }
            else if(interactable.gameObject.tag == "Dutch")
            {
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.Dutch;
            }
            else if(interactable.gameObject.tag == "Arabian")
            {
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.Arabic;
            }
            SceneManager.LoadScene(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
