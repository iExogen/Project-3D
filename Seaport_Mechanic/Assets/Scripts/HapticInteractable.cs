using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteractable : MonoBehaviour
{
    [Range(0,1)]
    public float intensity;
    public float duration;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    bool isScrewing = false;
    XRBaseController usingController;
    // Start is called before the first frame update
    void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.activated.AddListener(TriggerHaptic);
    }

    public void TriggerHaptic(BaseInteractionEventArgs arg)
    {
        if(arg.interactorObject is  XRBaseControllerInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    public void TriggerHaptic(XRBaseController controller)
    {
        usingController = controller;
        isScrewing = true;
    }

    private void Update()
    {
        if(isScrewing && rightActivate.action.ReadValue<float>() > 0.1f)
        usingController.SendHapticImpulse(intensity, duration);
        else if(isScrewing && leftActivate.action.ReadValue<float>() >0.1f)
            usingController.SendHapticImpulse(intensity, duration);
        else
            isScrewing=false;
    }
}
