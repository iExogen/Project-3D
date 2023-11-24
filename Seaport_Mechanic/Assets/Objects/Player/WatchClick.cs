using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class WatchClick : MonoBehaviour
{
    AudioSource sound;

    bool hasPressed;
    private XRSimpleInteractable interactable;
    public GameObject _miniStraddle;


    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        hasPressed = false;
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.hoverEntered.AddListener(StraddleSpawner);

    }


    public void StraddleSpawner(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRPokeInteractor)
        {
                hasPressed = true;
        }
    }

    private void Update()
    {
        if(hasPressed)
        {
            hasPressed = false;
            _miniStraddle.SetActive(!_miniStraddle.activeSelf);
        }
    }

}
