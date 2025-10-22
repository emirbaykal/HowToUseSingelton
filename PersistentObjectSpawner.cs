using System;
using UnityEngine;

public class PersistentObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject persistentObjectPrefab = null;
    
    // PRIVATE STATIC

    private static bool hasSpawned = false;

    private void Awake()
    {
        if(hasSpawned) return;
        
        SpawnPersistentObjects();

        hasSpawned = true;
    }

    private void SpawnPersistentObjects()
    {
        GameObject persistentObject = Instantiate(persistentObjectPrefab);
        DontDestroyOnLoad(persistentObject);
    }
}