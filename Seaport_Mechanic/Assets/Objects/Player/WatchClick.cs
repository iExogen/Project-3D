using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WatchClick : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressed;

    [SerializeField]GameObject _miniStraddle;


    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;

        

    }



    public void ShowHideMiniStraddle()
    {
        if(_miniStraddle.activeSelf == true)
        {
            _miniStraddle.SetActive(false);
        }
        else
        {
            _miniStraddle.SetActive(true);
        }
        
    }
}
