using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;//获取player
    private Transform _playerTrans;
    private Rigidbody2D _playerRigi;

    private bool leftison = false;//是否正在长按向左
    private bool rightison = false;//是否正在长按向右


    private float _Speed = 1;

    private float _leftForce = 0;//向左方向的力的大小
    private float _rightForce = 0;//向右方向的力的大小

    void Start()
    {
        _playerRigi = player.GetComponent<Rigidbody2D>();//获取player刚体
        _playerTrans = player.GetComponent<Transform>();//获取player位置变量
    }

    void Update()
    {
        LeftForce();//调用改变向左方向的力方法
        RightForce();//调用改变向右方向的力方法

        if (_playerTrans.position.y < 4)//判断player相当前相对于世界坐标的高度位置
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))//按住空格或方向键↑键
            {
                Jump();
            }
        }

        _playerRigi.AddForce(new Vector2(-_leftForce, 0));//对刚体施加向左方向力
        _playerRigi.AddForce(new Vector2(_rightForce, 0));//对刚体施加向右方向的力
    }

    public void leftDown()//响应事件：向左按下时
    {
        leftison = true;
    }

    public void leftUp()//响应事件；向左松手时
    {
        leftison = false;
    }

    public void rightDown()//响应事件：向右按下时
    {
        rightison = true;
    }

    public void rightUp()//响应事件：向右松手时
    {
        rightison = false;
    }

    public void LeftForce() //向左的力,长按逐渐增加向左的力，松手时受力归零
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || leftison)//按住A或方向键←键或ui中向左虚拟按键
        {
            _leftForce = _leftForce + Time.deltaTime * _Speed;//改变向左方向的力的大小
        }
        else
        {
            _leftForce = 0;//松手时刚体受到的力归0
        }
    }

    public void RightForce() //向右的力,长按逐渐增加向右的力，松手时受力归零
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || rightison)//按住D或方向键→键或ui中向右虚拟按键
        {
            _rightForce = _rightForce + Time.deltaTime * _Speed;//改变向右方向的力的大小
        }
        else
        {
            _rightForce = 0;//松手时刚体受到的力归0
        }
    }

    public void Jump() //跳跃
    {
        _playerRigi.AddForce(new Vector2(0, 200));//施加一个向上的瞬时力
    }
}