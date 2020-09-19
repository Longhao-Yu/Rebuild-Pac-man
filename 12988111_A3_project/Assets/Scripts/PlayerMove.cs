using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private Vector2 dest = Vector2.zero;
    void Start()
    {
        speed = 0.5f;//移动速度为0.5
        dest = this.transform.position;//把pacman当前位置存储到dest
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector2 temp =  Vector2.MoveTowards(transform.position,dest, speed);//使用补间运动将pacman从当前位置移动到dest
        Debug.Log("目的地： " + dest + "" + "当前位置: " + transform.position);
        GetComponent<Rigidbody2D>().MovePosition(temp);
        if ((Vector2)transform.position == dest || Valid(Vector2.up))
        {
            if (Input.GetKey(KeyCode.UpArrow) && Valid(Vector2.up))
            {
                dest = (Vector2)transform.position + Vector2.up * 4;//目的地为当前位置加上移动的方向上的位置
            }
            if (Input.GetKey(KeyCode.DownArrow) && Valid(Vector2.down))
            {
                dest = (Vector2)transform.position + Vector2.down * 4;
            }
            if (Input.GetKey(KeyCode.LeftArrow) && Valid(Vector2.left))
            {
                dest = (Vector2)transform.position + Vector2.left * 4;
            }
            if (Input.GetKey(KeyCode.RightArrow) && Valid(Vector2.right))
            {
                dest = (Vector2)transform.position + Vector2.right * 4;
            }
            Vector2 dir = dest - (Vector2)transform.position;//目的地位置减去现在的位置
            GetComponent<Animator>().SetFloat("DirX", dir.x);//如果目的地减现在位置的x大于1，说明pacman向右在走
            GetComponent<Animator>().SetFloat("DirY", dir.y);
        }
    } 

    private bool Valid(Vector2 dir)
    {
        Vector2 pos = transform.position;//存储现在位置
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);//发射一道激光，从要去的pos+dir位置到pos
        return hit.collider == GetComponent<Collider2D>();//如果碰到的是pacman的collider碰撞体，说明没有阻挡
    } 
}
