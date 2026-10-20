using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public List<string> characterNames = new List<string>();
    public List<string> dialogueLines = new List<string>();

    public int currentIndex;

    public GameObject dialoguePanelObj;
    public GameObject yesNoPanelObj;
    public GameObject eatAndDrinkObj;

    public DialoguePanel dialoguePanel;

    public void StartGame()
    {
        currentIndex = 0;

        //dialoguePanelObj.SetActive(true);

        dialoguePanel.ChangeName(characterNames[0]);
        dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
    }
    public void NextLine()
    {
        currentIndex++;

        if (dialogueLines[currentIndex] == "Y/N")
        {
            yesNoPanelObj.SetActive(true);
            dialoguePanelObj.SetActive(false);
        }
        else if (dialogueLines[currentIndex] == "EDM")
        {
            eatAndDrinkObj.SetActive(true);
            dialoguePanelObj.SetActive(false);
        }
        else
        {
            dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
        }
    }
}
