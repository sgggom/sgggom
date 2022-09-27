using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    public GameObject mainCamera;

    public Vector3 follow;

    // private float _x;
    // private float _y;

    // Start is called before the first frame update

    void Start()
    {
        follow = player.transform.position - mainCamera.transform.position;

        // _x = mainCamera.position.x - player.position.x;
        // _y = mainCamera.position.y - player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.position = player.GetComponent<Transform>().position;
        mainCamera.transform.position = player.transform.position - follow;

        // Debug.Log(mainCamera.transform.position);
        // Debug.Log(player.transform.position);
    }
}