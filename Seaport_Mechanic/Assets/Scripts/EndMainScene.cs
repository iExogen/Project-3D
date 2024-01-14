using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EndMainScene : MonoBehaviour
{
    private float timer;

    public AudioSource countdown;

    public InputActionProperty aButton;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timer+600f || GameManager.Instance.repairsDone==5)
        {
            SceneManager.LoadScene(2);
        }
        if (Time.time >= timer + 580f)
        {
            countdown.Play();
        }

        if (aButton.action.IsPressed())
        {
            timer = Time.time-580f;
        }
    }
}
