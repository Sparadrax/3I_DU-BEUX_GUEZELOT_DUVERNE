using UnityEngine;
using System.Collections;

public class EndJ1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnDestroy()
	{
		Application.LoadLevel("EndGameJ1");

	}
}
