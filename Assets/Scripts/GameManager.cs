using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField]
    int targetFrameRate = 15;

    private void Start () {
        // settings framerate for examination
        Application.targetFrameRate = targetFrameRate;
    }

}