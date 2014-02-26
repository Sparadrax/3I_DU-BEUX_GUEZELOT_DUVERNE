using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {


	public float hpCurrent = 100;

	[SerializeField]
	private Texture2D fullLife;
	[SerializeField]
	private Texture2D midLife;
	[SerializeField]
	private Texture2D lowLife;

	public Vector3 wantedPos;

	public GameObject leGameObj;
	public Transform target;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		target = gameObject.transform;

		/*if(Input.GetKeyDown("n"))
		   {
			hpCurrent -= 20;
		}
		if(Input.GetKeyDown("m"))
		   {
			hpCurrent += 20;
		}*/

		wantedPos = Camera.main.WorldToViewportPoint(target.position);
		

		if(hpCurrent <= 0.0f)
		{
			if(this.gameObject.name == "BaseJ2" || this.gameObject.name == "BaseJ1")	
			{	
				if(this.gameObject.name == "BaseJ2")
				{
					Application.LoadLevel("EndGameJ1");
				}
				else
				{
					Application.LoadLevel("EndGameJ2");
				}
				/*GameObject cam = GameObject.Find("Main Camera");
				cam.GetComponent<GUI_InGame_j1>().enabled = false;

				if (this.gameObject.name == "BaseJ2"){
					cam.GetComponent<Gui_EndGame>().name = "Joueur 1 ";
				}else if (this.gameObject.name == "BaseJ1"){
					cam.GetComponent<Gui_EndGame>().name = "Joueur 2 ";
				}
				cam.GetComponent<Gui_EndGame>().enabled = true;*/
				//Destroy(this.gameObject);
			}else{
				Destroy(this.gameObject);
			}
		}
	}


}
