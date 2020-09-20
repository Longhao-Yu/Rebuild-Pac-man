using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomePac : MonoBehaviour
{
    void Start()
    {
        Camera.main.orthographic = true;
        Camera.main.orthographicSize = 70;
    }

    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Animator>().SetFloat("DirY", 1);
            GetComponent<Animator>().SetFloat("DirX", 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Animator>().SetFloat("DirY", -1);
            GetComponent<Animator>().SetFloat("DirX", 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Animator>().SetFloat("DirX", -1);
            GetComponent<Animator>().SetFloat("DirY", 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Animator>().SetFloat("DirX", 1);
            GetComponent<Animator>().SetFloat("DirY", 0);
        }
    }
}
