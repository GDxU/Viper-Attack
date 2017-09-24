using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	public Helicopter helicopter;
	public Transform playerSpawnPOS; //Parent of the spawn points.
	public bool respawn = false;
	private Transform[] spawnPointsPOS;
	private bool lastToggle = false;
	private AudioSource innerVoice;

	//Sound files
	public AudioClip startW;

	// Use this for initialization
	void Start () 
	{
		spawnPointsPOS = playerSpawnPOS.GetComponentsInChildren<Transform>();
		//print(spawnPointsPOS.Length);

		AudioSource[] audioSources = GetComponents<AudioSource>();
		foreach(AudioSource audioSource in audioSources)
		{
			if(audioSource.priority == 1)
			{
				innerVoice = audioSource;
			}
		}

		innerVoice.clip = startW;
		innerVoice.Play();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(lastToggle != respawn)
		{
			Respawn();
			respawn = false;
		}
		else
		{
			lastToggle = respawn;
		}
	}

	private void Respawn()
	{
		int i = Random.Range(1, spawnPointsPOS.Length);
		transform.position = spawnPointsPOS[i].transform.position;
	}

	void OnFindClearArea()
	{
		helicopter.Call();
	}
}
