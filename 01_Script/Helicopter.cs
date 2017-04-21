using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip[] callSounds;
	public AudioClip[] radioReceiver;
	public float responderTime = 2f;

	private AudioSource sndSource;
	private int freq;

	// Use this for initialization
	void Start () {
	 sndSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("CallHeli")) {
			print("Called the Heli");
			freq = 0;
			sndSource.clip = callSounds[freq];
			sndSource.Play();
			Invoke("radioResponse", responderTime);
		}
	}

	void radioResponse ()
	{
		sndSource.clip = radioReceiver[freq];
		sndSource.Play();
	}
}
