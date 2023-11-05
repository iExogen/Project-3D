using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class StartGame : MonoBehaviour
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
            if (interactable.gameObject.tag == "Door")
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
