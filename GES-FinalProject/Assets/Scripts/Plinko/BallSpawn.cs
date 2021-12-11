using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    [SerializeField] public GameObject ballPrefab;

    public void SpawnBall()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-9.995f, 9.995f), 14, 13);
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }
}
