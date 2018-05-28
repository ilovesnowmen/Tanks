using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour 
{
	// We need to grab the tank data.
	public TankData pawn;

	// So keys can be changed for multi player or just more comfortable playing
	public KeyCode forwardKey = KeyCode.UpArrow;
	public KeyCode reverseKey = KeyCode.DownArrow;
	public KeyCode turnRightKey = KeyCode.RightArrow;
	public KeyCode turnLeftKey = KeyCode.LeftArrow;
	public KeyCode shootKey = KeyCode.Space;

	void Start ()
	{
		// get those componets and det this as player in GM
		pawn = GetComponent<TankData> ();
		GameManager.GM.player = this;
	}

	void Update ()
	{
		// Register input and move the player
		if (Input.GetKey (forwardKey)) 
		{
			pawn.mover.MoveForward (pawn.mover.tf.forward);
		}
		if (Input.GetKey (reverseKey)) 
		{
			pawn.mover.MoveBackward (pawn.mover.tf.forward * -1);
		}
		if (Input.GetKey (turnRightKey)) 
		{
			pawn.mover.Turn (1);
		}
		if (Input.GetKey (turnLeftKey)) 
		{
			pawn.mover.Turn (-1);
		}
		// Take the input and run the shoot function
		if (Input.GetKeyDown (shootKey)) {
			pawn.shooter.Shoot ();
		}
	}
}
