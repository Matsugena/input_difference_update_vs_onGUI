using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {
    string inputString = "";
    private string nl = System.Environment.NewLine;

    [SerializeField]
    Text displayText;

    float countFrame = 0f;

    private void Update () {
        if (displayText != null) {
            displayText.text = inputString;
        }
    }

    public void pushString (string input) {
        inputString += input;
    }

    private string countFrameString () {
        return countFrame.ToString () + Time.time + System.Environment.NewLine;
    }
}