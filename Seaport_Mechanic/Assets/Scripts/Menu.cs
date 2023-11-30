using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class Menu : MonoBehaviour
{

    public GameObject menu;
    public Transform head;
    public InputActionProperty menuButton;
    public XRSimpleInteractable interactable;
    private bool isInvisible;
    // Start is called before the first frame update
    void Start()
    {
        interactable.hoverEntered.AddListener(Follow);
    }

    public void Follow(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRPokeInteractor)
        {
                GameManager.Instance.repairsDone = 0;
                GameManager.Instance.screwsFixed = 0;
                GameManager.Instance.screwsRemoved = 0;
                SceneManager.LoadScene(0);
            LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(menuButton.action.triggered)
        {
         if(isInvisible)
            {
                menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized;
                isInvisible = false;
            }
            else
            {
                menu.transform.position = new Vector3(0, -20, 0);
                isInvisible = true;
            }
        }
        this.transform.LookAt(new Vector3(head.position.x, this.transform.position.y, head.position.z));
        this.transform.forward *= -1;
    }
}
