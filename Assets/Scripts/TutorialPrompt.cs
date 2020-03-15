using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPrompt : MonoBehaviour
{
    public PlayerController controller;
    Text text;

    public bool fixedText = false;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        if (controller.promptText == "!black")
        {
            text.color = Color.black;
            return;
        }
        if (!fixedText) 
            text.text = controller.promptText;
    }
}
