using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour 
{
    public Material newMtl;

    void FixedUpdate() 
	{
        Vector3 fwd = transform.TransformDirection(Vector3.forward) * 10;
        RaycastHit hit;
        Debug.DrawRay(transform.position, fwd, Color.green);

        if (Physics.Raycast(transform.position, (fwd), out hit))
        {
            hit.collider.GetComponentInChildren<Renderer>().material = newMtl;
        }
    }
}
