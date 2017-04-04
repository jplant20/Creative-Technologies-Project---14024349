using UnityEngine;
using System.Collections;

public class ActivateWater : MonoBehaviour 
{
	public ParticleSystem particles;

	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Debug.Log("Water Firing!");
			particles.Play();
		}

		if(Input.GetMouseButtonDown(1))
		{
			particles.Stop();
		}
	}
}
