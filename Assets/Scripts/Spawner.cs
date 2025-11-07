using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float SpawnRate = 1;
    [SerializeField] private GameObject HexaPrefab;
    [SerializeField] private float SpawnTime = 0.0f;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= SpawnTime)
        {
            Instantiate(HexaPrefab);
            SpawnTime = Time.time + 1 / SpawnRate;
        }
    }
}
