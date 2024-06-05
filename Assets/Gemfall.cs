using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Gemfall : MonoBehaviour
{
    public float roi = 2.0f;
    public float timer;
    public GameObject gemPrefab;

    private bool isAllowFall;
    // Start is called before the first frame update
    void Start()
    {
        isAllowFall = false;
    }

    // Update is called once per frame
    void Update()
    {   
        if (isAllowFall == false)
        {
            return;
        }
                

        

        timer = timer + Time.deltaTime;
        if (timer >= 2) 
        {
            Random.Range(-12, 12);
            float randomSpawn = Random.Range(-12 , 12);
            timer = 0;
            Vector3 spawnPosition = new Vector3(randomSpawn, 10, 0);
            Instantiate(gemPrefab, spawnPosition, Quaternion.identity);

        }
        
    }
    public void setIsAllowFall(bool isAllowFall)
    {
        this.isAllowFall = isAllowFall;
    }
}
