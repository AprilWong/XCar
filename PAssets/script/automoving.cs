using UnityEngine;
using System.Collections;

public class automoving : MonoBehaviour {
	public float speed = 20f;
	public float turnSpeed = 50f;
	private float powerInput;
	private float turnInput;
	private Rigidbody carRigidbody;
	
	
	void Awake () 
	{
		carRigidbody = GetComponent <Rigidbody>();
	}
	
	void Update () 
	{
		powerInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");
	}
	
	void FixedUpdate()
	{	
		carRigidbody.AddRelativeForce(0f, 0f, powerInput * speed);
		carRigidbody.AddRelativeTorque(0f, turnInput * turnSpeed, 0f);
		
	}
}
