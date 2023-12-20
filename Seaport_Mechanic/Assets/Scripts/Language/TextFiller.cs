using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextFiller : MonoBehaviour
{
    /*
    public TMP_Text PlayerName;
    public TMP_Text PlayerScore;
    public TMP_Text NPC1Score;
    public TMP_Text NPC2Score;
    public TMP_Text NPC3Score;
    public TMP_Text NPC5Score;
    public TMP_Text NPC6Score;

    public Slider playerSlider;
    public Slider NPC1Slider;
    public Slider NPC2Slider;
    public Slider NPC3Slider;
    public Slider NPC5Slider;
    public Slider NPC6Slider;
    */
    public TMP_Text toUpperText;
    public TMP_Text toLowerText;
    /*
    private string PlayerNameString;
    private float npcScore=0;
    private float timeBetweenNPCScore = 10;
    private float timer;
    */
    public TMP_Text startButton;
    public TMP_Text endButton;
    
    //private bool botsWorking;

    void Start()
    {
        /*
        timer = Time.time;
        npcScore = 0;
        PlayerNameString = LanguageManager.Instance.GetText(LanguageManager.TextID.PlayerNameText);
        PlayerName.text = PlayerNameString; 
        PlayerScore.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText)+GameManager.Instance.repairsDone;
        NPC1Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        NPC2Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        NPC3Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        NPC5Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        NPC6Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        */
        startButton.text = LanguageManager.Instance.GetText(LanguageManager.TextID.StartButton);
        endButton.text = LanguageManager.Instance.GetText(LanguageManager.TextID.EndButton);

        toUpperText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ToUpperText);
        toLowerText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ToLowerText);

    }

    // Update is called once per frame
    void Update()
    {
        /*
            PlayerScore.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + GameManager.Instance.repairsDone;
        if (!botsWorking) return;
        if (Time.time > timer+timeBetweenNPCScore * (npcScore + 1))
            {
                npcScore++;
                playerSlider.value = GameManager.Instance.repairsDone * 0.2f;
                NPC1Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
                NPC1Slider.value = npcScore * 0.1f;
                NPC2Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
                NPC2Slider.value = npcScore * 0.1f;
                NPC3Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
                NPC3Slider.value = npcScore * 0.1f;
                NPC5Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
                NPC5Slider.value = npcScore * 0.1f;
                NPC6Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
                NPC6Slider.value = npcScore * 0.1f;
                if (npcScore >= 10)
                {
                    NPC1Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreDone);
                    NPC2Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreDone);
                    NPC3Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreDone);
                    NPC5Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreDone);
                    NPC6Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreDone);
                    GameManager.Instance.finishPlace += 5;
                botsWorking = false;
                }
            }
            if (GameManager.Instance.repairsDone == GameManager.Instance.totalRepairs)
            {
                PlayerScore.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreDone);
            }
        */
    }
}
