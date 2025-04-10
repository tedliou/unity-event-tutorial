using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int deathEnemyAmount = 0;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(6);

            // Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity);
            var enemy = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity);
            enemy.GetComponent<EnemyController>().onDeath.AddListener(AddDeathAmount);
            Debug.Log("Spawn an Enemy");
        }
    }

    public void AddDeathAmount()
    {
        deathEnemyAmount += 1;
        Debug.Log("Death Enemy Amount: " + deathEnemyAmount);
    }
}