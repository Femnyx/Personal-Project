using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] private float timer = 2;
    private float bulletTime;

    
    public GameObject enemyBullet;
    public Transform spawnPoint;
    public float enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        bulletTime = timer; 
    }

    // Update is called once per frame
    void Update()
    {
        ShootAtPlayer();
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = timer;

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(Vector3.forward * enemySpeed, ForceMode.Impulse);
        Destroy(bulletObj, 2);
    }
}
