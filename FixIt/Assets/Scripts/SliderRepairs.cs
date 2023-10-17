using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SliderRepairs : MonoBehaviour
{
    [SerializeField] private Slider _Slider;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(_Slider.tag == "Player")
        {
            _Slider.value = GameManager.Instance.repairsDone * 0.2f;
        }
        else
        {
            _Slider.value = GameManager.Instance.npcRepairs*0.1f;
        }
    }
}
