using UnityEngine;
using System.Collections;

public class ParticleCollision : MonoBehaviour 
{
	void OnTriggerEnter(Collider collider)
	{ 
		Debug.Log("Fire Detected!");
	}
}
