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

        interactable.selectEntered.AddListener(Select);
    }
    public void Select(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRRayInteractor)
        {
            if(interactable.gameObject.tag == "NextLanguage")
            {
                LanguageManager.Instance.chosenLanguage++;
            }
            else if(interactable.gameObject.tag == "PreviousLanguage")
            {
                LanguageManager.Instance.chosenLanguage--;
            }
            SceneManager.LoadScene(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
