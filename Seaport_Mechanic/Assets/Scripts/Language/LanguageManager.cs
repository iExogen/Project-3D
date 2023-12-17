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
        PlayerNameText,
        SettingsText,
        LanguageText,
        EquipmentText,
        FirstTipText,
        LockerRoomBoss,
        GarageBoss1,
        GarageBoss2,
        ScoreText,
        ScoreDone,
        StartButton,
        EndButton,
        StartButtonPressed,
        RestartButton,
        EndScreenSucces,
        EndScreenFailure,
        ToUpperText,
        ToLowerText
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
        AddElement(Language.English, TextID.PlayerNameText, "Player1");
        AddElement(Language.Nederlands, TextID.PlayerNameText, "Speler1");

        AddElement(Language.English, TextID.SettingsText, "Settings");
        AddElement(Language.Nederlands, TextID.SettingsText, "instellingen");

        AddElement(Language.English, TextID.LanguageText, "Language:");
        AddElement(Language.Nederlands, TextID.LanguageText, "taal:");

        AddElement(Language.English, TextID.EquipmentText, "Pick up");
        AddElement(Language.Nederlands, TextID.EquipmentText, "oprapen");

        AddElement(Language.English, TextID.FirstTipText, "Tip: \r\nYou can move with the left joystick and rotate with the right one, or you can use the B button to teleport.\r\nGrabbing items can be done with the grab buttons.");
        AddElement(Language.Nederlands, TextID.FirstTipText, "Tip: \r\nJe kan bewegen met de linker joystick en draaien met de rechter, of gebruik de B knop om te teleporteren.\r\nObjecten grijpen doe je met de grijpknoppen.");

        AddElement(Language.English, TextID.LockerRoomBoss, "I'm glad you could make it! Before we get started you need to change into your working gear. Safety is very important at DPWorld. When ready to work go TELEPORT on the door to my right.");
        AddElement(Language.Nederlands, TextID.LockerRoomBoss, "Goed dat je er bent! Voor we beginnen moet je je werkkledij aandoen. Veiligheid is heel belangrijk bij DPWorld. Als je klaar bent TELEPORTEER op de deur rechts van mij");

        AddElement(Language.English, TextID.GarageBoss1, "Step into the garage, Technician! Your mission: restore functionality to the straddle carrier at workstation 4. Meet with me at that location, where I'll provide detailed instructions for a flawless repair.");
        AddElement(Language.Nederlands, TextID.GarageBoss1, "Welkom in de garage, monteur! Uw opdracht is om de straddle carrier op werkstation 4 weer in werking te stellen. We spreken daar af, waar ik u gedetailleerde instructies zal geven voor een vlekkeloze reparatie.");

        AddElement(Language.English, TextID.GarageBoss2, "Let's get started! To identify the malfunctioning components, simply tap your wristwatch and look for the glowing red spheres. You can also seek out flickering sparks and warning symbols, which also indicate the appropriate tools required for each repair. Your inventory can be accessed by glancing at the back of your left wrist. Moreover, you'll notice a workstation beside me, stacked with hefty components necessary for the repairs. These must be manually transported to the designated repair sites. When you're fully prepared, initiate your work by pressing the glistening green button.");
        AddElement(Language.Nederlands, TextID.GarageBoss2, "Laten we beginnen! Om de defecte componenten te identificeren, tikt u gewoon op uw horloge en zoekt u de rode bollen. U kunt ook uitkijken naar flikkerende vonken en waarschuwingssymbolen, die ook de juiste gereedschappen aangeven die nodig zijn voor elke reparatie. Uw inventaris kunt u zien door op de achterkant van uw linkerpols te kijken. Bovendien ziet u naast mij een werkstation met zware componenten die nodig zijn voor de reparaties. Deze moeten handmatig worden vervoerd naar de aangewezen reparatielocaties. Zodra u volledig bent voorbereid, start u uw werk door op de groene knop te drukken.");

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
    }

}
