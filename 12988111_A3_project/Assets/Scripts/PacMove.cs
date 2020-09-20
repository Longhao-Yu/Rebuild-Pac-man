using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMove : MonoBehaviour
{
    float Dirx;
    float Diry;
    public int lastTime = 0;
    private float timer = 0;
    private float moveTime = 0;
    private const float moveWait = 2f;
    Vector2 currD;
   [SerializeField]
    private Transform[] transformArray;
    void Start()
    {
        Camera.main.orthographic = true;
        Camera.main.orthographicSize = 70;
    }

    void Update()
    {
        timer += Time.deltaTime;
        Dirx = transformArray[0].position.x;  
        Diry = transformArray[0].position.y;
        currD = (Vector2)transformArray[0].position;
        if (timer > (moveTime + moveWait))//每2s运行一次
        {
            moveTime = (int)timer;
            MoveObjects();
            Debug.Log("current position" + Dirx + ", " + Diry);
        }
    }

    private void MoveObjects()
    {
        //Vector3 temp = Vector3.MoveTowards(transform.position, transformArray[0].position, 2);
        //GameObject.Find("Pacman").GetComponent<Rigidbody2D>().MovePosition(temp);
        if (Dirx == 26 && Diry == 26)
        {
            transformArray[0].position = new Vector3(26, 10, 0);//直接改变game object的位置
        }
        else if (Dirx == 26 && Diry == 10)
        {
            transformArray[0].position = new Vector3(6, 10, 0);
        }
        else if (Dirx == 6 && Diry == 10)
        {
            transformArray[0].position = new Vector3(6, 26, 0);
        }
        else if (Dirx == 6 && Diry == 26)
        {
            transformArray[0].position = new Vector3(26, 26, 0);
        }
        Vector2 dir = (Vector2)transformArray[0].position - currD;
        GameObject.Find("Pacman").GetComponent<Animator>().SetFloat("DirX", dir.x);
        GameObject.Find("Pacman").GetComponent<Animator>().SetFloat("DirY", dir.y);
    }
}
