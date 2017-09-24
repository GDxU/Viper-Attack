using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour 
{
	public AudioClip startSound;
	public AudioClip goodArea;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () 
	{
		audioSource = GetComponent<AudioSource>();
		audioSource.clip = startSound;
		audioSource.Play();
	}

	void OnFindClearArea()
	{
		audioSource.clip = goodArea;
		audioSource.Play();

		Invoke("CallHelicopter", goodArea.length + 1f);
	}

	void CallHelicopter()
	{
		SendMessageUpwards("OnMakeInitialHelicopterCall");
	}
}
