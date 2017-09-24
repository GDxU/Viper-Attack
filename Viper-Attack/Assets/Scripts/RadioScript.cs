using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour 
{
	public AudioClip initialHelicopterCall;
	public AudioClip initialCallReply;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () 
	{
		audioSource = GetComponent<AudioSource>();
	}
	
	void onMakeInitialHelicopterCall()
	{
		audioSource.clip = initialHelicopterCall;
		audioSource.Play();

		Invoke("InitialReply", initialHelicopterCall.length + 1f);
	}

	void InitialReply()
	{
		audioSource.clip = initialCallReply;
		audioSource.Play();
		BroadcastMessage("OnDispatchedHelicopter");
	}
}
