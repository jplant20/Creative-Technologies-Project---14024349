using UnityEngine;
using System.Collections;

public class SceneMenu : MonoBehaviour 
{
	public string levelToload = "Menu";

	private void OnGUI()
	{
		if (Input.GetKeyDown (KeyCode.M)) 
		{
			Application.LoadLevel (levelToload);
		}
	}
}
