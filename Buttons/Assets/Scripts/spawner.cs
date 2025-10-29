using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawn;
    public GameObject spawnBoss;
    int k = 1;
    float mn = 0;
    public int max = 0;
    public int min = 0;

    void Start()
    {
        InvokeRepeating("Spawner", 1f, 0.35f);
        InvokeRepeating("SpawnBoss", 17.5f, 20f - mn);
        InvokeRepeating("Sp1", 5f, 5f);
        InvokeRepeating("Sp2", 15f, 20f);
        InvokeRepeating("MinInterval", 20f, 45f);
    }

    void Spawner()
    {
        if (k > 0)
        {
            Instantiate(spawn, gameObject.transform);
            k--;
        }
    }

    void SpawnBoss()
    {
        Instantiate(spawnBoss, gameObject.transform);    
    }

    void Sp1()
    {
        k += Random.Range(min, 4 + max);
    }
    void Sp2()
    {
        max++;
    }
    void MinInterval()
    {
        if (mn < 12)
        {
            mn += 0.65f;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
