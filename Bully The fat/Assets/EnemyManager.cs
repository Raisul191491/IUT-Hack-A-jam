
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public Transform[] m_SpawnPoints;
    public GameObject m_EnemyPrefab;
    public int enemycount = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnNewEnemy());
    }


    IEnumerator SpawnNewEnemy()
    {
      
        while ( enemycount < 5)
        {
            int randomNumber = Mathf.RoundToInt(Random.Range(0f, m_SpawnPoints.Length-1));

            print(randomNumber);

            Instantiate(m_EnemyPrefab, m_SpawnPoints[randomNumber].transform.position, Quaternion.identity);

            yield return new WaitForSeconds(5.0f);

            enemycount++;
        }

    }

}