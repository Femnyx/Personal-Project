using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] powerup;
    private Rigidbody mob1Rb;

    private float xSpawn = 0.0f;
    private float ySpawnBound = 16.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 1.0f;
    public


    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawn, xSpawn);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(transform.position.x - 15, transform.position.y, -1.37f);
        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle"))
        {
            SpawnEnemy();
            Debug.Log("Went through collider");
        }
    }
}