using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ElJeffe : MonoBehaviour
{

    public GameObject position2;
    public GameObject position3;
    public GameObject player;
    private bool firstPosition = false;
    private bool secondPosition = false;
    private bool fourthPosition = false;
    public ButtonFollowVisual pressEnter;
    public TMP_Text tutorialText;
    public GameObject hasGazed;
    public GameObject sparks;
    public GameObject stopBlock;
    // Start is called before the first frame update
    void Start()
    {
        tutorialText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.GarageBoss1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,player.transform.position) < 5f && !firstPosition)
        {
            firstPosition = true;
        }
        else if(Vector3.Distance(transform.position,player.transform.position) > 5f && firstPosition && !secondPosition)
        {
            secondPosition = true;
            transform.position = position2.transform.position;
            transform.rotation = position2.transform.rotation;
            tutorialText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.GarageBoss2);
        }
        if(pressEnter.startButtonText.color == Color.green)
        {
            tutorialText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.GarageBoss3);
        }
        if(pressEnter.startButtonText.color == Color.green && !hasGazed.activeSelf && !fourthPosition)
        {
            fourthPosition = true;
            tutorialText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.GarageBoss4);
            transform.position = position3.transform.position;
            transform.rotation = position3.transform.rotation;
            stopBlock.SetActive(false);
        }
        if(!sparks.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }
}
