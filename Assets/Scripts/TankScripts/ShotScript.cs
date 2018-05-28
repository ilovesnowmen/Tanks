using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour 
{
	// We need the objects Transform
	private Transform tf;
	// Variables set in the shoot function from the Tank Data
	public float speed;
	public float destructionTimer;
	public float damage;


	void Start () 
	{
		// Get that componet <3
		tf = GetComponent<Transform> ();

	}

	void Update ()
	{
		// This moves the shot and keeps track of how long it has been alive for.
		tf.Translate (Vector3.forward * speed * Time.deltaTime);
		destructionTimer -= Time.deltaTime;
		// If too old die
		if (destructionTimer <= 0) 
		{
			Destroy (gameObject);
		}
	}

	// If collide die
	void OnTriggerEnter (Collider other)
	{
		Destroy (gameObject);
	}
}
