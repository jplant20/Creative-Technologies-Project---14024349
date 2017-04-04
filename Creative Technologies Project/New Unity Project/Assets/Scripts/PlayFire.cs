using UnityEngine;
using System.Collections;

public class PlayFire : MonoBehaviour 
{
	//public ParticleSystem particles;
	public Vector3 ObjectSpawnPosition;
	public GameObject fireobject;
	bool CanPlayFire = true;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.P) && CanPlayFire == true) 
		{
			Instantiate (fireobject, ObjectSpawnPosition, Quaternion.Euler(270, 0, 0));
			CanPlayFire = false;
		}
	}
}
