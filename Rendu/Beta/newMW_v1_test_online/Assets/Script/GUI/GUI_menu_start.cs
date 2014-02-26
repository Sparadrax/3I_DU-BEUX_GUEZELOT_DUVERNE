using UnityEngine;
using System.Collections;

public class GUI_menu_start : MonoBehaviour {
	[SerializeField]
	private Texture2D leFond;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		//menu principal du GUI
		GUI.Box(new Rect(0,0,Screen.width,Screen.height),leFond);
		GUI.Box(new Rect((Screen.width/2)-((Screen.width/4)/2),(Screen.height/2)-((Screen.height/2)/2),Screen.width/4,Screen.height/2) , "MENU");
		//les bouttons
		if(GUI.Button(new Rect((Screen.width/2)-((Screen.width/8)/2),(Screen.height/2)-((Screen.height/8)/2)-Screen.height/8,Screen.width/8,Screen.height/8),"lancer"))
		{
			Application.LoadLevel("MenuStart");
		}
		if(GUI.Button(new Rect((Screen.width/2)-((Screen.width/8)/2),(Screen.height/2)-((Screen.height/8)/2)+Screen.height/8,Screen.width/8,Screen.height/8),"quitter"))
		{
			Application.Quit();
		}
	
	}
}
