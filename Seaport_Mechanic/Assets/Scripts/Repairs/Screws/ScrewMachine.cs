using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class ScrewMachine : MonoBehaviour
{
    public Transform visualTarget;
    public Vector3 localAxis;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    private Vector3 offset;
    private Transform attachTransform;

    private Vector3 startPosition;
    private bool isFollowing = false;
    private bool needsFixing = true;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = visualTarget.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ScrewDriver"))
        {
                attachTransform = other.transform;
                offset = visualTarget.position - attachTransform.position;
                isFollowing = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("ScrewDriver") && needsFixing)
        {
            visualTarget.position = startPosition;
            isFollowing = false;
        } 

    }

    // Update is called once per frame
    void Update()
    {
        RemoveOldPlate();
        
    }

    private void RemoveOldPlate()
    {
        if (isFollowing && leftActivate.action.ReadValue<float>() > 0.1f && needsFixing)
        {
            Vector3 localTargetPosition = visualTarget.InverseTransformPoint(attachTransform.position + offset);
            Vector3 constrainedLocalTargetPosition = Vector3.Project(localTargetPosition, localAxis);

            visualTarget.position = visualTarget.TransformPoint(constrainedLocalTargetPosition);
        }
        else if (isFollowing && rightActivate.action.ReadValue<float>() > 0.1f && needsFixing)
        {
            Vector3 localTargetPosition = visualTarget.InverseTransformPoint(attachTransform.position + offset);
            Vector3 constrainedLocalTargetPosition = Vector3.Project(localTargetPosition, localAxis);

            visualTarget.position = visualTarget.TransformPoint(constrainedLocalTargetPosition);
        }
        if (visualTarget.localPosition.z <= -0.1 && needsFixing)
        {
            needsFixing = false;
            GetComponent<Rigidbody>().isKinematic = false;
            GameManager.Instance.screwsRemoved++;
        }
    }
}