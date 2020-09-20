using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level1Color : MonoBehaviour
{
    public void OnMouseEnter()
    {
        SpriteRenderer sr = this.transform.GetComponent<SpriteRenderer>();
        Sprite sprite = Resources.Load("level1-2", typeof(Sprite)) as Sprite;
        sr.sprite = sprite;
    }
    public void OnMouseExit()
    {
        SpriteRenderer sr = this.transform.GetComponent<SpriteRenderer>();
        Sprite sprite = Resources.Load("level1-1", typeof(Sprite)) as Sprite;
        sr.sprite = sprite;
    }
    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    SceneManager.LoadScene("Level 1");
        //}
    }
}
