using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBox : MonoBehaviour
{
    public GameObject star;
    private GameObject child;

    private float time=10;
    private float coldtime=0;

    void Update()
    {
        if (star.gameObject.activeSelf==false)
        {
            coldtime = coldtime + 1 * Time.deltaTime;
            if (coldtime > time) 
            {
                openStar();
                coldtime = 0;
            }
            // Invoke("openStar",time);
        }
        
    }

    public void openStar()
    {
        star.gameObject.SetActive(true);
        print(1);
    }
}