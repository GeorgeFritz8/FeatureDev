using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;
    public float SpawnTimer;
    public Vector3 SpawnPosition;
    public int EnemyCount;
    void Start()
    {
        StartCoroutine(StartWave());
    }
    public IEnumerator StartWave()
    {
        for (int i = 0; i < EnemyCount; i++)
        {
            Instantiate(Enemy, SpawnPosition, transform.rotation);
            yield return new WaitForSeconds(SpawnTimer);
        }
    }
}
