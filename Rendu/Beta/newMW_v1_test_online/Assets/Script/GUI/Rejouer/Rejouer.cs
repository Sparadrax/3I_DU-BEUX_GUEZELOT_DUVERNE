using UnityEngine;
using System.Collections;

public class Rejouer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		if(GUI.Button(new Rect(((Screen.width)/2)-(70/2),((Screen.height)/2)-10,70,20),"Menu"))
		{
			Application.LoadLevel("Menu1");
		}
		if(GUI.Button(new Rect(((Screen.width)/2)-(70/2),((Screen.height)/2)+20,70,20),"Quitter"))
		{
			Application.Quit();
		}
	}
}
