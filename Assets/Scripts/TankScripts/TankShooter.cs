using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : MonoBehaviour 
{
	// pull tank data and shotscript
	private TankData data;
	public ShotScript shot;


	void Start () 
	{
		// Grab Tank Data
		data = GetComponent<TankData> ();
	}

	public void Shoot ()
	{
		// Check to see if you can fire and if so shoot
		if (data.canFire == true) 
		{
			// Clone the object with the shot script and set it's transform to the tank
			// This allows easy access to the variables in the shot script
			ShotScript clone = (ShotScript)Instantiate(shot, transform.position, transform.rotation);
			// Speed, Time Out Delay, and damage
			clone.speed = data.bulletForce;
			clone.destructionTimer = data.bulletLife;
			clone.damage = data.shotDamage;
			// Set the 'Reloader' and make can fire false
			data.reload = data.fireCoolDown;
			data.canFire = false;
		}
	}
}
