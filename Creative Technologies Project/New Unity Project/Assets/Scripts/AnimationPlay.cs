using UnityEngine;
using System.Collections;

public class AnimationPlay : MonoBehaviour 
{	
	private Animation CubeBone;

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			CubeBone = GetComponent<Animation>();
			CubeBone.Play("CubeBone");
		}
	}
}
