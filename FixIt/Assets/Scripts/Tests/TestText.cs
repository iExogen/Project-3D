using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestText : MonoBehaviour
{
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        switch (GameManager.Instance.chosenLanguage)
        {
            case GameManager.language.English:
                {
                    text.text = "welcome";
                    break;
                }
            case GameManager.language.Dutch:
                {
                    text.text = "welgekomen";
                    break;
                }
            case GameManager.language.Arabian:
                {
                    text.text = "Arabian hello";
                    break;
                }
            default:
                {
                    text.text = "something went wrong, blame Seppe";
                    break;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
