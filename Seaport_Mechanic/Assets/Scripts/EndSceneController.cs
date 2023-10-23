using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndSceneController : MonoBehaviour
{

    public TMP_Text review;
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance.repairsDone == GameManager.Instance.totalRepairs)
        {
            review.text =LanguageManager.Instance.GetText(LanguageManager.TextID.EndScreenSucces) + GameManager.Instance.finishPlace;
        }
        else
        {
            review.text = "you didn't finish your repairs!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
