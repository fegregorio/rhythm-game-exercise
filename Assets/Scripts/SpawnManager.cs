using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float startDelay = 2f;
    private int count = 0;
    private string[] map = { "L", "G", "H", "I", "N", "N", "R" };
    private float[] time = { 1f, 0.5f, 0.5f, 1f, 0.5f, 0.5f, 1f };

    void Start()
    {
        Invoke("SpawnProjectile", startDelay);
    }

    void SpawnProjectile()
    {
        Vector3 spawnPos = GameObject.Find(map[count]).transform.position;
        spawnPos.y += 2;

        Instantiate(projectilePrefab,
            spawnPos,
            projectilePrefab.transform.rotation
            );

        Invoke("SpawnProjectile", time[count]);
        count += 1;
    }
}
