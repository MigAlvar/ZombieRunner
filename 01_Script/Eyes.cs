using UnityEngine;
using System.Collections;

public class Eyes : MonoBehaviour {

	public float FOVFactor;

	private Camera eyes;
	private float defaultFOV;

	// Use this for initialization
	void Start () {
		eyes = GetComponentInChildren<Camera>();
		defaultFOV = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton ("Zoom")) {
			eyes.fieldOfView = 60f / FOVFactor;
		} else {
			eyes.fieldOfView = defaultFOV;
		}

	}
}
