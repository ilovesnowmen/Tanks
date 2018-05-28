using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour 
{
	private TankData data;

	void Start()
	{
		data = GetComponent<TankData> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<DamageUp> () == true) 
		{
			data.shotDamage += 5;
		}
	}
}