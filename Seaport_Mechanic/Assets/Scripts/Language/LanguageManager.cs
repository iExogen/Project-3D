using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : Singleton<LanguageManager>
{
    public enum Language
    {
        English,
        Nederlands,
    }
    public enum TextID
    {
        RestartText,
        LanguageText,
        EquipmentText,
        FirstTipText,
        SecondTipText,
        ThirdTipText,
        LockerRoomBoss,
        GripTip,
        GarageBoss1,
        GarageBoss3,
        GarageBoss4,
        ScoreText,
        ScoreDone,
        StartButton,
        EndButton,
        StartButtonPressed,
        RestartButton,
        EndScreenSucces,
        EndScreenFailure,
        ToUpperText,
        ToLowerText,
        Succes,
        Fail,
    }
    public Language chosenLanguage = Language.English;
    private Dictionary<Language, Dictionary<TextID, string>> allTexts = new Dictionary<Language, Dictionary<TextID, string>>();
    // Start is called before the first frame update
    void Start()
    {      
        InitAllText();

    }

    public string GetText(TextID textID) //returns text based on ID and chosenLanguage
    {
       
        if (allTexts.ContainsKey(chosenLanguage))
        {
            string result;
            if(allTexts[chosenLanguage].TryGetValue(textID, out result))
            {
                return result;
            }
            else
            {
                return "text not found in LanguageManager";
            }
        }
        return "language not found in languageManager";
    }
    public void AddElement(Language lang,TextID id,string text)
    { 
        if(allTexts.ContainsKey(lang))
        {
            if(!allTexts[lang].ContainsKey(id))
            {
                allTexts[lang].Add(id, text);
            }       
        }
        else
        {
            allTexts.Add(lang, new Dictionary<TextID, string>());
            allTexts[lang].Add(id, text);
        }
    }

    private void InitAllText()
    {

        AddElement(Language.English, TextID.RestartText, "Restart");
        AddElement(Language.Nederlands, TextID.RestartText, "herstarten");

        AddElement(Language.English, TextID.LanguageText, "Language:");
        AddElement(Language.Nederlands, TextID.LanguageText, "taal:");

        AddElement(Language.English, TextID.EquipmentText, "Pick up");
        AddElement(Language.Nederlands, TextID.EquipmentText, "oprapen");

        AddElement(Language.English, TextID.FirstTipText, "Tip: You can Grab items with the grab buttons.");
        AddElement(Language.Nederlands, TextID.FirstTipText, "Tip: Objecten grijpen doe je met de grijpknoppen.");

        AddElement(Language.English, TextID.SecondTipText, "Tip: you can use the B and Y buttons to teleport.");
        AddElement(Language.Nederlands, TextID.SecondTipText, "Tip: gebruik de B en X knoppen om te teleporteren.");

        AddElement(Language.English, TextID.ThirdTipText, "Tip: open the menu with the MENU button");
        AddElement(Language.Nederlands, TextID.ThirdTipText, "Tip: open het menu met de MENU knop");

        AddElement(Language.English, TextID.LockerRoomBoss, "I'm glad you could make it! Before we get started you need to change into your working gear. Safety is very important at DPWorld. When ready to work go TELEPORT on the door to my right.");
        AddElement(Language.Nederlands, TextID.LockerRoomBoss, "Goed dat je er bent! Voor we beginnen moet je je werkkledij aandoen. Veiligheid is heel belangrijk bij DPWorld. Als je klaar bent TELEPORTEER op de deur rechts van mij");

        AddElement(Language.English, TextID.GripTip, "Press GRIP button to grab an object");
        AddElement(Language.Nederlands, TextID.GripTip, "Druk de GRIJP knop om een item vast te pakken");

        AddElement(Language.English, TextID.GarageBoss1, "Step into the garage, Technician! Your mission: restore functionality to the straddle carrier at workstation 4. Meet with me at that location, where I'll provide detailed instructions for a flawless repair.");
        AddElement(Language.Nederlands, TextID.GarageBoss1, "Welkom in de garage, monteur! Uw opdracht is om de straddle carrier op werkstation 4 weer in werking te stellen. We spreken daar af, waar ik u gedetailleerde instructies zal geven voor een vlekkeloze reparatie.");

        AddElement(Language.English, TextID.GarageBoss3, "You need to repair this straddle carrier. Look at the twist lock next to me to start your first repair.");
        AddElement(Language.Nederlands, TextID.GarageBoss3, "Je moet je straddle carrier repareren. Kijk naar de twist lock naast mij om je eerste reparatie te starten.");

        AddElement(Language.English, TextID.GarageBoss4, "The danger symbol indicates what tool you need to use. It's also your inventory. Hold your hand on it to summon the tool.");
        AddElement(Language.Nederlands, TextID.GarageBoss4, "De gevaarsymbolen duiden aan welke tool je nodig hebt. Het is ook je inventaris. Houd je hand erop om een tool te krijgen.");

        AddElement(Language.English, TextID.ScoreText, "Current repairs: ");
        AddElement(Language.Nederlands, TextID.ScoreText, "Huidige reparaties: ");

        AddElement(Language.English, TextID.ScoreDone, "DONE");
        AddElement(Language.Nederlands, TextID.ScoreDone, "GEDAAN");

        AddElement(Language.English, TextID.StartButton, "Start");
        AddElement(Language.Nederlands, TextID.StartButton, "Starten");

        AddElement(Language.English, TextID.EndButton, "Finish");
        AddElement(Language.Nederlands, TextID.EndButton, "Eindig");

        AddElement(Language.English, TextID.StartButtonPressed, "Finish your repairs");
        AddElement(Language.Nederlands, TextID.StartButtonPressed, "Maak je reparaties af");

        AddElement(Language.English, TextID.RestartButton, "restart");
        AddElement(Language.Nederlands, TextID.RestartButton, "herstarten");

        AddElement(Language.English, TextID.EndScreenSucces, "You finished ");
        AddElement(Language.Nederlands, TextID.EndScreenSucces, "je bent geindigd op plaats ");

        AddElement(Language.English, TextID.EndScreenFailure, "You didn't finish your repairs!");
        AddElement(Language.Nederlands, TextID.EndScreenFailure, "je hebt je reparaties niet afgemaakt!");

        AddElement(Language.English, TextID.ToUpperText, "To upper floor");
        AddElement(Language.Nederlands, TextID.ToUpperText, "Naar Boven");

        AddElement(Language.English, TextID.ToLowerText, "To ground floor");
        AddElement(Language.Nederlands, TextID.ToLowerText, "Naar beneden");

        AddElement(Language.English, TextID.Succes, "You succeeded in your repair!");
        AddElement(Language.Nederlands, TextID.Succes, "Je bent in je reparaties geslaagd!");

        AddElement(Language.English, TextID.Succes, "You failed to finish your repairs in time!");
        AddElement(Language.Nederlands, TextID.Succes, "Je hebt je reparaties niet op tijd afgekregen!");
    }

}
