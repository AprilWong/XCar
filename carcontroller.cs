using UnityEngine;
using System.Collections;

public class carcontroller : MonoBehaviour {
	public float rotationSpeed = 100F;

	
	// Update is called once per frame
	void Update () {
		float rotation = Input.GetAxis ("Mouse X") * rotationSpeed;
		print ("rotation= " + rotation);
		transform.Rotate (0, rotation, 0);
	}
}
