using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor.UnitTesting;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    private Transform _playerTrans;
    private Rigidbody2D _playerRigi;


    private float _Speed = 1;

    private float _leftForce = 0;
    private float _rightForce = 0;

    // private float _leftSpeed = 0;
    // private float _rightSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        _playerRigi = player.GetComponent<Rigidbody2D>();
        _playerTrans = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        LeftForce();
        RightForce();
        if (_playerTrans.position.y < 4)
        {
            Jump();
        }

        _playerRigi.AddForce(new Vector2(-_leftForce, 0));
        _playerRigi.AddForce(new Vector2(_rightForce, 0));
    }

    public void LeftForce() //向左的力,长按逐渐增加向左的力，松手时受力归零
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _leftForce = _leftForce + Time.deltaTime * _Speed;
        }
        else
        {
            _leftForce = 0;
        }
    }

    public void RightForce() //向右的力,长按逐渐增加向右的力，松手时受力归零
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _rightForce = _rightForce + Time.deltaTime * _Speed;
        }
        else
        {
            _rightForce = 0;
        }
    }

    public void Jump() //跳跃
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            _playerRigi.AddForce(new Vector2(0, 200));
        }
    }
}