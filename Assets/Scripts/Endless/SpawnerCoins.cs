using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{
    [SerializeField] private GameObject CoinsPrefab;
    [SerializeField] private Transform[] CoinsPositions;

   private void Start()
    {
        StartCoroutine(GenerateCoins());
    }

    IEnumerator GenerateCoins()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            GameObject newCoinsPrefab = Instantiate(CoinsPrefab, CoinsPositions[Random.Range(0, 3)].position, Quaternion.identity);
            Destroy(newCoinsPrefab, 4);
        }
    }
}