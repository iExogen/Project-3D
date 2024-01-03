using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class InventoryManager : MonoBehaviour
{
    public GameObject itemSlot;
    private Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = itemSlot.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            itemSlot.transform.position = transform.position;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            itemSlot.transform.position = spawnPoint;
        }
    }
}
