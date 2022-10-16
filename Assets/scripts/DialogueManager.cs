using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    private static DialogueManager instance;

    private Story currentstory;
    public bool dialoguePlaying { get ; private set ; }

    private void Awake()
     {
         if (instance != null)
         {
             Debug.LogWarning("Found more than one DialogueManager in the scene.");
         }
         instance = this;
     }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialoguePlaying = false;
        dialoguePanel.SetActive(false);
    }

    private void Update()
    {
        if (!dialoguePlaying)
        {
            return;
        }

        /*if (InputManager.GetInstance().GetSubmitPressed())
        {
             ContinueStory();
        }*/
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentstory = new Story(inkJSON.text);
        dialoguePlaying = true;
        dialoguePanel.SetActive(true);
    }

    public IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.2f);

        dialoguePlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    private void ContinueStory()
    {
        if (currentstory.canContinue)
        {
            dialogueText.text = currentstory.Continue();
        }
        else
        {
            StartCoroutine(ExitDialogueMode());
        }
    }
    /* This is for the script for Player Control fixed Update

        if (DialogueManger.GetInstance().dialoguePlaying)
    {
	    return;
    }

    */
}
