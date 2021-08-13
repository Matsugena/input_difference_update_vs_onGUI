using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {
    string inputString = "";

    [SerializeField]
    Text displayText;

    private void Update () {
        if (displayText != null) {
            displayText.text = inputString;
        }
    }

    public void pushString (string input) {
        inputString += input;
    }
}