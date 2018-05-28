using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour 
{
	// Variables for holding Componets
	private CharacterController control;  // Character Controller Componet
	[HideInInspector] public Transform tf;// Transform Componet [Hidden to be left alone]
	private TankData data; //TankData

	void Start ()
	{
		// GetComponet at start and put them in the variables
		control = GetComponent<CharacterController> ();
		tf = GetComponent<Transform> ();
		data = GetComponent<TankData> ();
	}

	// Move function
	public void MoveForward ( Vector3 moveVector )
	{
		// Move using the vector passed into the function
		control.SimpleMove (moveVector.normalized * data.forwardSpeed);
	}
	public void MoveBackward (Vector3 moveVector)
	{
		control.SimpleMove (moveVector.normalized * data.reverseSpeed);
	}

	// Turn function
	public void Turn ( float direction )
	{
		// Turn in direction positive for right and negitive for left
		tf.Rotate (0, Mathf.Sign (direction) * data.turnSpeed * Time.deltaTime, 0);
	}
}
