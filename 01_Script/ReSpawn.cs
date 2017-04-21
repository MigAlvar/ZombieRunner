using UnityEngine;
using System.Collections;

public class ReSpawn : MonoBehaviour {

	public Transform Spawners;
	public bool spawn = false;

	private Transform[] playerSpawner;
	private Transform[] medicSpawner;
	private Transform[] weaponSpawner;
	private Transform[] ammoSpawner;
	private Transform[] zombieSpawner;
	private int number;

	// Use this for initialization
	void Start ()
	{
		playerSpawner = Spawners.GetComponentsInChildren<Transform>();

	}
	
	// Update is called once per frame
	void Update ()
	{
		//for checking purposes. Remove once called from died() function
		playerSpawn();

	
	}

	public void playerSpawn(){
		if (spawn) {
			number = Random.Range(1, playerSpawner.Length);
			transform.position = playerSpawner[number].transform.position;
			spawn = false;
		}
	 } 

}
