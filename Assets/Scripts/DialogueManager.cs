using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public List<string> characterNames = new List<string>();
    public List<string> dialogueLines = new List<string>();

    public List<string> dialogueLinesY1 = new List<string>();
    public List<string> dialogueLinesN1 = new List<string>();

    public List<string> dialogueLinesY2 = new List<string>();
    public List<string> dialogueLinesN2 = new List<string>();

    public int currentIndex;

    public GameObject dialoguePanelObj;
    public DialoguePanel dialoguePanel;

    public GameObject yesNoPanelObj1;
    public GameObject yesNoPanelObj2;
    public GameObject yesNoPanelObj3;


    public bool dialogue1;
    public bool dialogue2;
    public bool dialogue3;

    public GameObject deadScreen;
    
    public void StartGame()
    {
        dialogue1 = true;
        currentIndex = 0;

        dialoguePanelObj.SetActive(true);

        dialoguePanel.ChangeName(characterNames[0]);
        dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
    }
    public void NextLine()
    {
        currentIndex++;

        if (dialogue1 == true)
        {
            if (dialogueLines[currentIndex] == "Y/N1")
            {
                yesNoPanelObj1.SetActive(true);
                dialoguePanelObj.SetActive(false);
            }
            else
            {
                dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
            }
        }
        if (dialogue2 == true)
        {
            if (dialogueLines[currentIndex] == "Y/N2")
            {
                yesNoPanelObj2.SetActive(true);
                dialoguePanelObj.SetActive(false);
            }
            else
            {
                dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
            }
        }
        if (dialogue3 == true)
        {
            if (dialogueLines[currentIndex] == "Y/N3")
            {
                yesNoPanelObj3.SetActive(true);
                dialoguePanelObj.SetActive(false);
            }
            else
            {
                dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
            }
        }
    }

    public void NextDialogue()
    {
        if (dialogue1 == true)
        {
            dialogue1 = false;
            dialogue2 = true;

            dialoguePanel.ChangeName(characterNames[1]);
            dialoguePanelObj.SetActive(true);
        }
        else if (dialogue2 == true)
        {
            dialogue2 = false;
            dialogue3 = true;

            dialoguePanel.ChangeName(characterNames[0]);
            dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
        }
    }

    public void Yes2()
    {
        for (int i = 0; i < dialogueLinesY1.Count; i++)
        {
            dialogueLines.Add(dialogueLinesY1[i]);
        }

        currentIndex++;
        dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
    }
    public void No2()
    {
        for (int i = 0; i < dialogueLinesN1.Count; i++)
        {
            dialogueLines.Add(dialogueLinesN1[i]);
        }

        currentIndex++;
        dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
    }

    public void Yes3()
    {
        for (int i = 0; i < dialogueLinesY2.Count; i++)
        {
            dialogueLines.Add(dialogueLinesY2[i]);
        }

        currentIndex++;
        dialoguePanel.ChangeDialogue(dialogueLines[currentIndex]);
    }
    public void No3()
    {
        deadScreen.SetActive(true);
    }
}
