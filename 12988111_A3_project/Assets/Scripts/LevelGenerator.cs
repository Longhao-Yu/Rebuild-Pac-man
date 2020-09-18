using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelGenerator : MonoBehaviour
{
    public int[,] tileMap = new int[,]
    {
      {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
      {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
      {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
      {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
      {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
      {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
      {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
      {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
      {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
      {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
      {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
      {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
      {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
      {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
      {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    };

    public float TileSize;
    public Vector2 StartPoint;//top left corner of the map

        // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        TileSize = 1;
        StartPoint = new Vector2(2, 30);
        PopulateTileMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopulateTileMap()
    {
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 14; j++)
            {

                GameObject prefab = Resources.Load(tileMap[i, j].ToString()) as GameObject;
                GameObject tile = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
                //tile.transform.position = new Vector3(StartPoint.x + (TileSize * i) + (TileSize / 2), StartPoint.y + (TileSize * j) + (TileSize / 2), 0);
                tile.transform.position = new Vector3(StartPoint.x + (TileSize * j * 2), StartPoint.y - (TileSize * i * 2), 0);
                if (i > 0 && i < 9 && j == 0)
                {
                    tile.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                }
                if (i == 3 || i == 11 || i == 12 || i == 14 || i == 10)
                {
                    tile.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                }
                Debug.Log("x= " + (StartPoint.x + (TileSize * j * 2)) + " " + "y = " + (StartPoint.y - (TileSize * i * 2)));
                Debug.Log(prefab);
            }
        }
    }
}
