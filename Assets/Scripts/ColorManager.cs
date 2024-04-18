using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color startColor;
    public Color loseColor;
    Camera _cam;
    private void Start() {
        _cam = GetComponent<Camera>();
        _cam.backgroundColor = startColor;
    }
    public void ChangeToLoseColor(){
        _cam.backgroundColor = loseColor;
    }
    public void ChangeToStartColor(){
        _cam.backgroundColor = startColor;
    }
}
