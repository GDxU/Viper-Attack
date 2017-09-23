using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour 
{
	private Camera eyes;
	private float defaultPView;


	// Use this for initialization
	void Start () 
	{
		eyes = GetComponent<Camera>();
		defaultPView = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton("Zoom"))
		{
			eyes.fieldOfView = defaultPView / 1.5f;
		}
		else
		{
			eyes.fieldOfView = defaultPView;
		}
	}
}
