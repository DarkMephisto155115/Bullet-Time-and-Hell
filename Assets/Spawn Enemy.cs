using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemy : MonoBehaviour
{
    public GameObject theEnemy;
    public int waitTime;
    public int xpos;
    public int zpos;
    public int enemyCount;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public bool stop;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    private void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator EnemyDrop()
    {
        while (!stop)
        {
            yield return new WaitForSeconds(spawnWait);
            while (true)
            {
                if (enemyCount < 3)
                {
                    xpos = Random.Range(-8, 24);
                    zpos = Random.Range(-21, 12);
                    Instantiate(theEnemy, new Vector3(xpos, (float)0.5, zpos), Quaternion.identity);
                    yield return new WaitForSeconds(1);
                    enemyCount++;
                }
                else
                {
                    yield return new WaitForSeconds(1);
                    enemyCount = 0;
                    break;
                }
                
            }
        }
        
    }

    
}
