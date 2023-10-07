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
        switch (GameManager.Instance.language)
        {
            case 1:
                {
                    text.text = "welcome";
                    break;
                }
            case 2:
                {
                    text.text = "welgekomen";
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
