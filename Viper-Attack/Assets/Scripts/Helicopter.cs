using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour 
{
	private bool called = false;
	public AudioClip callSound;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("CallHelicopter") && !called)
		{
			called = true;
		}
	}
}
