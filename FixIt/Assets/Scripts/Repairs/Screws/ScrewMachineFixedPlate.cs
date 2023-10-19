using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScrewMachineFixedPlate : MonoBehaviour
{
    public Transform visualTarget;
    public Vector3 localAxis;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    private Vector3 offset;
    private Transform attachTransform;


    private bool isFollowing = false;
    private bool needsFixing = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ScrewDriver")
        {

            attachTransform = other.transform;
            offset = visualTarget.position - attachTransform.position;
            isFollowing = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ScrewDriver")
        {
            isFollowing = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        FixNewPlate();
    }

    private void FixNewPlate()
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
        if (visualTarget.localPosition.z >= 0.2 && needsFixing)
        {
            needsFixing = false;
            GameManager.Instance.screwsFixed++;
        }
    }
}
