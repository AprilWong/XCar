using UnityEngine;
using System.Collections;

public class raincontrol : MonoBehaviour {
	// Use this for initialization
	GameObject rain;
	//ParticleRenderer rain;
	void Start () {
		rain = GameObject.Find("Rain");
		print (rain);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			rain.particleEmitter.enabled = !rain.particleEmitter.enabled;
			rain.particleEmitter.emit = !rain.particleEmitter.emit;
		}
	}
}
