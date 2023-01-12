using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private Transform[] EnemyPositions;

   private void Start()
    {
        StartCoroutine(GenerateEnemy());
    }

    IEnumerator GenerateEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            GameObject newEnemyPrefab = Instantiate(EnemyPrefab, EnemyPositions[Random.Range(0, 3)].position, Quaternion.identity);
            Destroy(newEnemyPrefab, 4);
        }
    }
}
