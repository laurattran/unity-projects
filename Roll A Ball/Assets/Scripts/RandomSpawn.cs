using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour {

    public Transform[] spawnPoints;
    private float spawnTime = 1.5f;

    public GameObject pickup;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnPickups", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnPickups()
    {
        int spawnIndex = Random.Range(0,spawnPoints.Length);
        Instantiate(pickup, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
}
