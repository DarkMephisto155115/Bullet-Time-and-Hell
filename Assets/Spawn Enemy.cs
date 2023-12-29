using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        spawnWait = Random.Range(spawnWait, spawnMostWait);
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
                    xpos = Random.Range(1, 8);
                    zpos = Random.Range(-18, 8);
                    Instantiate(theEnemy, new Vector3(xpos, (float)0.5, zpos), Quaternion.identity);
                    yield return new WaitForSeconds(1);
                    enemyCount++;
                }
                else
                {
                    enemyCount = 0;
                    break;
                }
                
            }
        }
        
    }

    
}
