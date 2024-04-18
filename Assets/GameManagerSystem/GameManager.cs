using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData gameData;
    public GameEvent OnWinEvent;
    bool _isFistTap = true;

    private void Start() {
        gameData.ResetLevel();
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0) && !gameData.isRunning && _isFistTap){
            gameData.isRunning = true;
            _isFistTap = false;
        }
    }   

    public void DecrementRemainingDots(){
        gameData.dotsRemaining--;
        if(gameData.dotsRemaining <= 0){
            gameData.dotsRemaining = 0;
            OnWinEvent.Raise();
        }
    }

    public void LoadSameLevel(){
        gameData.ResetLevel();
        _isFistTap = true;
    }

    public void LoadNextLevel(){
        gameData.currentLevel++;
        _isFistTap = true;
        gameData.ResetLevel();
    }

    public void StopGame(){
        gameData.isRunning = false;
    }
}
