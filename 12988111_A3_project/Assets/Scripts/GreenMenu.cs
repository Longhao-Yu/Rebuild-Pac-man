using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMenu : MonoBehaviour
{
    public int lastTime = 0;
    private float timer = 0;
    private float moveTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > (moveTime + 3))
        {
            GetComponent<Animator>().SetBool("Power", true);
            GetComponent<Animator>().SetFloat("Recover", 0);
            if (timer > (moveTime + 6))
            {
                GetComponent<Animator>().SetFloat("Scare", 3);
                GetComponent<Animator>().SetBool("Power", false);
                if (timer > (moveTime + 7))
                {
                    GetComponent<Animator>().SetFloat("Recover", 1);
                    GetComponent<Animator>().SetFloat("Scare", 0);
                    moveTime = (int)timer;
                }
            }
        }
    }
}
