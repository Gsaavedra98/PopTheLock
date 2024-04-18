using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{
    public GameData gameData;
    GameObject _currentDot;
    public GameEvent OnDotMissed;
    public GameEvent OnDotScored;
    private void OnTriggerEnter2D(Collider2D other) {
        _currentDot = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other) {
        _currentDot = null;
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0) && gameData.isRunning){            
            if(_currentDot != null){
                Destroy(_currentDot);
                OnDotScored.Raise();
            }else{
                OnDotMissed.Raise();
            }
        }
    }
}
