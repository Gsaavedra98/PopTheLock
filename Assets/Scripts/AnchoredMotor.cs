using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class AnchoredMotor : MonoBehaviour
{
    public GameData gameData;
    [Header("Speed")]
    [SerializeField, Range(0, 100)] private int speed = 5;
    [Header("Direction")]
    [SerializeField] private Direction _direction = Direction.Clockwise;
    Vector3 _initialPosition;
    Transform _anchor;

    private void Start() {
        _anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
        _initialPosition = transform.localPosition;
    }

    private void Update() {
        if(gameData.isRunning)
        transform.RotateAround(_anchor.position, Vector3.forward, speed * Time.deltaTime * (int)_direction);
        if(_didTap && gameData.isRunning){            
            ChangeDirection();
        }
    }

    bool _didTap{
        get{
            return Input.GetMouseButtonDown(0);
        }
    }

    public void ChangeDirection(){
        switch(_direction){
            case Direction.Clockwise:
            _direction = Direction.AntiClockwise;
            break;
            case Direction.AntiClockwise:
            _direction = Direction.Clockwise;
            break;
        }
    }

    public void ResetPosition(){
        transform.localPosition = new Vector3(0,_initialPosition.y,0);
        transform.localRotation = quaternion.identity;
        gameData.isRunning = false;
    }

    public void Stop(){
        gameData.isRunning = false;
    }
}

public enum Direction{
    Clockwise = 1,
    AntiClockwise = -1
}
