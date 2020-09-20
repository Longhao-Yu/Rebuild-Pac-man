using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level2Color : MonoBehaviour
{
    public void OnMouseEnter()
    {
        SpriteRenderer sr = this.transform.GetComponent<SpriteRenderer>();//通过获取gameobject的组件来进行图片更改
        Sprite sprite = Resources.Load("level2-2", typeof(Sprite)) as Sprite;
        sr.sprite = sprite;
    }
    public void OnMouseExit()
    {
        SpriteRenderer sr = this.transform.GetComponent<SpriteRenderer>();
        Sprite sprite = Resources.Load("level2-1", typeof(Sprite)) as Sprite;
        sr.sprite = sprite;
    }
    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    SceneManager.LoadScene("Level 2");
        //}
    }
}
