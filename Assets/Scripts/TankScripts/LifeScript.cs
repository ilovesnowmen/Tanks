using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour 
{
	// get some bariable place holders
	public float health;
	public float damageTanken;
	// get tank data ready
	public TankData data;

	void Start ()
	{
		// Grab tank data and set the object life
		data = GetComponent<TankData> ();
		health = data.life;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.GetComponent<ShotScript> () == true)
		{
			// check to see if what hit you was a bullet. If so take damage
			ShotScript grab = other.GetComponent<ShotScript> ();
			damageTanken = grab.damage;
			health -= damageTanken;
			// if out of health die
			if (health <= 0) 
			{
				Destroy (gameObject);
			}
		}
	}

}
