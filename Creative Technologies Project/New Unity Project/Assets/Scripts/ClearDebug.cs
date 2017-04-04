using UnityEngine;
using System.Collections;

public class ClearDebug : MonoBehaviour 
{
	void Start ()
	{
		StartCoroutine(ClearConsole());
	}
	IEnumerator ClearConsole()
	{
		// wait until console visible
		while(!Debug.developerConsoleVisible)
		{
			yield return null;
		}
		yield return null; // this is required to wait for an additional frame, without this clearing doesn't work (at least for me)
		Debug.ClearDeveloperConsole();
	}
}
