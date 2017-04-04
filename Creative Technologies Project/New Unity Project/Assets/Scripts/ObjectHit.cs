using UnityEngine;
using System.Collections;

public class ObjectHit : MonoBehaviour 
{
	void Start()
	{
		InvokeRepeating ("FixedUpdate", 0.0f, 3.0f);
	}

	void FixedUpdate() 
	{
		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast (transform.position, (fwd), out hit) && hit.collider.tag == "Name1") 
		{
			print ("Object Detected! " + hit.collider.gameObject.name);
		}

		if (Physics.Raycast (transform.position, (fwd), out hit) && hit.collider.tag == "Name2") 
		{
			print ("Object Detected! " + hit.collider.gameObject.name);
		} 

		if (Physics.Raycast (transform.position, (fwd), out hit) && hit.collider.tag == "Name3") 
		{
			print ("Object Detected! " + hit.collider.gameObject.name);
		} 

		if (Physics.Raycast (transform.position, (fwd), out hit) && hit.collider.tag == "Name4") 
		{
			print ("Object Detected! " + hit.collider.gameObject.name);
		} 

		if (Physics.Raycast (transform.position, (fwd), out hit) && hit.collider.tag == "Name5") 
		{
			print ("Object Detected! " + hit.collider.gameObject.name);
		} 
	}
}
