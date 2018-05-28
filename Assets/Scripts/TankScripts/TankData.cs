using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour 
{
	// Firstly we need to set up variables to hold information about our tanks
	public float forwardSpeed; // Move forwards speed
	public float reverseSpeed; // Move backwards speed
	public float turnSpeed; // Turn Speed
	public float bulletForce; // Bullet Speed
	public float shotDamage; // Bullet Damage
	public float fireCoolDown; // Fire Rate
	public float bulletLife;
	public float life;
	[HideInInspector] public float reload;
	[HideInInspector] public bool canFire = true;


	// We need some variables to hold componets but we dont want them messed with
	[HideInInspector] public TankMover mover; // For TankMover
	[HideInInspector] public TankShooter shooter; // For TankShooter

	void Start () 
	{
		// Fill the variables with the proper componets
		mover = GetComponent<TankMover> ();
		shooter = GetComponent<TankShooter> ();
	}

	void Update ()
	{
		// This keeps track on if your tank can fire.
		if (canFire == false) 
		{
			// If it can't start reloading
			reload -= Time.deltaTime;
			if (reload <= 0) 
			{
				// fully reloaded and can fire now.
				canFire = true;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<DamageUp> () == true) 
		{
			shotDamage += shotDamage;
		}
	}

}
