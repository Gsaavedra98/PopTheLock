using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainingDotsTextUI : MonoBehaviour
{
    public GameData gameData;
    TextMeshPro _text;
    private void Start() {
        _text = GetComponent<TextMeshPro>();
        _text.text = gameData.dotsRemaining.ToString();
    }
    private void Update() {
        if(gameData != null)
        _text.text = gameData.dotsRemaining.ToString();
    }
}
