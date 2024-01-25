using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletshoot : MonoBehaviour
{

    [SerializeField] private float timer = 10;
    private float bulletTime;

    public GameObject enemyBullet;
    public Transform spawnPoint; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = timer;

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint);
    }
}
