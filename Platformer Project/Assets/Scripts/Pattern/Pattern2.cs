using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Pattern2 : MonoBehaviour
{
    public GameObject warningSign;
    public GameObject enemyPrefab;

    public int spawnerCount = 1;
    public float spawnCycle = 4;

    private void OnEnable()
    {
        StartCoroutine(SpawnEnemy());
    }

    private void OnDisable()
    {
        StopCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(-8.53f, 1.54f, 0);
        GameObject warning = Instantiate(warningSign, spawnPos, Quaternion.identity);

        yield return new WaitForSeconds(1f);
        Destroy(warning);
        CreateEnemyInstance(1);


        gameObject.SetActive(false);

    }

    private void CreateEnemyInstance(int count)
    {
        for(int i = 0; i < count; i++)
        {
            float randomValue = Random.Range(-16, 16);
            Vector3 spawnPosition = new Vector3(randomValue, 9, 0);
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
