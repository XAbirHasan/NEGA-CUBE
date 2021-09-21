using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject[] levelPrefabs;
	public Transform playerTransform;

	private float zSpawn = 0f;
	private float groundLength = 100f; 
	private List<GameObject> activeLevel = new List<GameObject>();

	// Use this for initialization
	void Start () 
	{
		SpawnLevel(0);
		SpawnLevel(0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(playerTransform.position.z > zSpawn-(1*groundLength))
        {
			SpawnLevel(Random.Range(1, levelPrefabs.Length));
			DeleteLevel();
        }
	}


	// to spwan new level
    public void SpawnLevel(int levelIndex)
    {
		//Debug.Log(zSpawn);
		GameObject active = Instantiate(levelPrefabs[levelIndex], transform.forward * zSpawn , transform.rotation);
		activeLevel.Add(active);
		zSpawn += groundLength;
    }

	// for delete a unused level

	public void DeleteLevel()
    {
		Destroy(activeLevel[0]);
		activeLevel.RemoveAt(0);
    }

}


