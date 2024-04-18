using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelTextUI : MonoBehaviour
{
    public GameData gameData;
    TextMeshProUGUI _text;
    private void Start() {
        _text = GetComponent<TextMeshProUGUI>();
        _text.text = "Level: " + gameData.currentLevel.ToString();
    }
    private void Update() {
        if(gameData != null)
        _text.text = "Level: " + gameData.currentLevel.ToString();
    }
}
