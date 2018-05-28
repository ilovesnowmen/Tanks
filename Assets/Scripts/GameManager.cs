using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
	// Lets make a singleton GM
	public static GameManager GM;
	// Grab the player's input controller this is the player.
	public InputController player;

	void Awake ()
	{
		// There can only be one
		if (GM == null) 
		{
			GM = this;
			DontDestroyOnLoad (gameObject);
		} 
		else 
		{
			Destroy (gameObject);
		}
	}
}
