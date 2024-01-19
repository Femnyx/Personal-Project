using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public int numberOfWalls = 4;
    public float wallLength = 1.5f;
    public float playerTriggerDistance = 5f;

    private List<GameObject> wallInstances = new List<GameObject>();
    private Transform player;
    private void Start()
    {
        player = Camera.main.transform;
        InstantiateWalls();
    }


    void InstantiateWalls()
    {
        for (int i = 0; i < numberOfWalls; i++)
        {
            GameObject wallPrefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
            GameObject wall = Instantiate(wallPrefab, new Vector3(i * -wallLength, 0, 0), wallPrefab.transform.rotation);
            wallInstances.Add(wall);
        }
    }


    public void ReplaceWall(Transform wall)
    {
        //Destroys the oldest wall that was made
        numberOfWalls++;
        //GameObject oldWall = wallInstances[0];
        wall.localPosition = new Vector3((numberOfWalls - 1) * -wallLength, 0, 0);
        Debug.Log(wall.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle"))
        {
            ReplaceWall(other.transform.parent);

        }
    }
}
