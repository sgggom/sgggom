using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject _Player;
    private Transform _PlayerTrans;
    

    public float _Speed = 5;
    
    public float _LeftSpeed = 0;
    private float _RightSpeed = 0;
        
    // Start is called before the first frame update
    void Start()
    {
        _PlayerTrans = _Player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)|Input.GetKey(KeyCode.A))
        {
            if (_LeftSpeed<100)
            {
                _LeftSpeed = _LeftSpeed + Time.deltaTime * 100 * _Speed;
            }
            else
            {
                _LeftSpeed = 100;
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow)|Input.GetKeyUp(KeyCode.A)|(_LeftSpeed>0))
        {
            _PlayerTrans.position = _PlayerTrans.position + Vector3.left * Time.deltaTime * _LeftSpeed*_Speed; 
            _LeftSpeed = _LeftSpeed - Time.deltaTime * 200;
        }
        else
        {
            _LeftSpeed = 0;
        }

        
        
        if (Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.D))
        {
            if (_RightSpeed<100)
            { 
                _RightSpeed = _RightSpeed + Time.deltaTime * 100 * _Speed; 
            }
            else
            {
                _RightSpeed = 100;
            }
        }

        if (Input.GetKeyUp(KeyCode.RightArrow)|Input.GetKeyUp(KeyCode.D)|(_RightSpeed>0))
        {
            _PlayerTrans.position = _PlayerTrans.position + Vector3.right * Time.deltaTime * _RightSpeed*_Speed; 
            _RightSpeed = _RightSpeed - Time.deltaTime * 200;
        }
        else
        {
            _RightSpeed = 0;
        }
    }
}
