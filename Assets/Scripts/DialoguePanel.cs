using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialoguePanel : MonoBehaviour
{
    [Header ("Name")]
    public string characterName;
    public TextMeshProUGUI nameText;

    [Header ("Dialogue")]
    public string characterDialogue;
    public TextMeshProUGUI dialogueText;

    private void Start()
    {
        //gameObject.SetActive(false);
    }

    public void ChangeName(string newName)
    {
        characterName = newName;
        nameText.text = characterName;
    }
    public void ChangeDialogue(string newDialogue)
    {
        characterDialogue = newDialogue;
        dialogueText.text = characterDialogue;
    }
}
