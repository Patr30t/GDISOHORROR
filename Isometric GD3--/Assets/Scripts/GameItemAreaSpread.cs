﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItemAreaSpread : MonoBehaviour
{
    public GameObject itemsToSpread;
    public int numItemsToSpawn = 20;

    public float itemXSpread  =10;
    public float itemYSpread = 0;
    public float itemZSpread = 10;
    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i < numItemsToSpawn; i++)
        {
            SpreadItem();
            
        }

    }

void SpreadItem()
{
    Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
    GameObject clone = Instantiate(itemsToSpread, randPosition , Quaternion.identity);
}
   
}
