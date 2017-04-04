using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	public Rect button = new Rect(15, 15, 200, 110);
	public string buttonLabel = "Load Level";
	public string levelToload = "Main Scene";

	private void OnGUI()
	{
		if (GUI.Button (button, buttonLabel)) 
		{
			Application.LoadLevel (levelToload);
		}
	}
}
