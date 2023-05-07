using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinSpawner : MonoBehaviour
{
    public float repeatRate = 5;
    private float timer = 0;
    public float height = 5;
    public GameObject prefabCoin;


    // Update is called once per frame
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnCoin();
        }

        timer += Time.deltaTime;
    }

    private void SpawnCoin()
    {
        GameObject newCoin = Instantiate(prefabCoin);
        newCoin.transform.position = transform.position + new Vector3(2, Random.Range(-height + 4, height - 4), 0);
    }
    

}

