using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBox : MonoBehaviour
{
    public GameObject star;
    private GameObject child;

    private int time;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (star.gameObject.activeSelf==false)
        {
            time = Random.Range(5, 10);
           Invoke("openStar",time);
        }
        
    }

    public void openStar()
    {
       star.gameObject.SetActive(true);
    }
}
