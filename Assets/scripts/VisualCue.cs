using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualCue : MonoBehaviour
{
    private bool PlayerinRange;

    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private void Awake()
    {
        PlayerinRange = false;
        visualCue.SetActive(false);
    }

    private void Update()
    {
        if (PlayerinRange && !DialogueManager.GetInstance().dialoguePlaying)
        {
            visualCue.SetActive(true);
            /*if (PlayerInput.GetInstance().GetInteractPressed())
            {
                DialogueManager.GetInstance().enterDialogueMode(inkJSON);
            }*/
        }
        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            PlayerinRange = true;
        }
    }

    private void OnTriggerExit2D (Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            PlayerinRange = false;
        }
    }
}
