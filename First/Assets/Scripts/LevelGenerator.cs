using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private int countOfPlatforms = 100;
    [SerializeField] private float minY = .1f;
    [SerializeField] private float maxY = 1f;
    [SerializeField] private float levelWidth = 5f;

    void Start()
    {
        Vector3 spawnPos = new Vector3();

        for (int i = 0; i < countOfPlatforms; i++) 
        {
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        }
    }

   
}
