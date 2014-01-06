using UnityEngine;
using System.Collections;

public class GUI_InGame_j1 : MonoBehaviour {

	private bool lockCam = false;
	private Transform myTransform;
	[SerializeField]
	private GameObject Batiment_Infanterie_1;
	[SerializeField]
	private GameObject MinionsTank;
	private GameObject P1;
	private GameObject P2;
	[SerializeField]
	private Texture2D Batiments;
	[SerializeField]
	private Texture2D Batiments1_1;
	[SerializeField]
	private Texture2D Batiments2;
	[SerializeField]
	private Texture2D Batiments2_1;
	[SerializeField]
	private Texture2D Batiments3;
	[SerializeField]
	private Texture2D Batiments3_1;
	[SerializeField]
	private Texture2D Batiments4;
	[SerializeField]
	private Texture2D Batiments4_1;

	private bool batiment1 = false;
		private bool batiment1_1 = false;
	private bool batiment2 = false;
		private bool batiment2_1 = false;
	private bool batiment3 = false;
		private bool batiment3_1 = false;
	private bool batiment4 = false;
		private bool batiment4_1 = false;

	private GameObject pSelect;




	public bool m_lockCam{
		get { return lockCam;}
		set { lockCam = value; }
	}


	// Use this for initialization
	void Start () {
		myTransform = transform;
		P1 = GameObject.Find("Player1");
		P2 = GameObject.Find("Player2");

	}
	
	// Update is called once per frame
	void Update () {

		if(P1.GetComponent<MovementClick>().IsSelected == true)
		{
			pSelect = P1;
		}
		if(P1.GetComponent<MovementClick>().IsSelected == false)
		{
			pSelect = P2;
		}

		//Création batiment
		if(Input.GetMouseButtonDown(0))
		{
			if(batiment1)
			{
			RaycastHit hit;
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit, 1000))
			{ 

					GameObject batiment1v1 =(GameObject) Instantiate(Batiment_Infanterie_1,new Vector3(hit.point.x, hit.point.y, hit.point.z) , Quaternion.identity);
				batiment1v1.AddComponent<unitee_terre_v1>();
					pSelect.GetComponent<PlayerBaseScript>().Batiment1ON = true;
				if(P1.GetComponent<MovementClick>().IsSelected == true)
					{


						batiment1v1.GetComponent<unitee_terre_v1>().alliance = 1;
					}
				else
					{

						batiment1v1.GetComponent<unitee_terre_v1>().alliance = 2;
					}
			}
			//ajout du script de spawn d'unitées
				batiment1 = false;
			}
			if(batiment2)
			{
				RaycastHit hit;
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);

				if(Physics.Raycast(ray, out hit, 1000))
				{ 
					GameObject batiment2v1 =(GameObject) Instantiate(MinionsTank,new Vector3(hit.point.x, hit.point.y, hit.point.z) , Quaternion.identity);
					batiment2v1.AddComponent<Unitee_Tank_1>();
					pSelect.GetComponent<PlayerBaseScript>().Batiment2ON = true;
					if(P1.GetComponent<MovementClick>().IsSelected == true)
					{
						batiment2v1.GetComponent<Unitee_Tank_1>().alliance = 1;
					}
					else
					{
						batiment2v1.GetComponent<Unitee_Tank_1>().alliance = 2;
					}

				}
				//ajout du script de spawn d'unitées
				batiment2 = false;
			}
		}

		//Si le joueur fais un clic droit ça annule tout les ordres de créations
		if(Input.GetMouseButtonDown(1))
		{
			  batiment1 = false;
			  batiment1_1 = false;
			  batiment2 = false;
			  batiment2_1 = false;
			  batiment3 = false;
			  batiment3_1 = false;
			  batiment4 = false;
			  batiment4_1 = false;
		}
	}

	void OnGUI(){
		//GUI BOX

		GUI.Box(new Rect(0,(Screen.height/4)*3,Screen.width,Screen.height/4),"");
		//GUI BOUTTON
		if(P1.GetComponent<MovementClick>().IsSelected || P2.GetComponent<MovementClickj2>().IsSelected)
		{
			//BOUTON CAMLOCK
		if(GUI.Button(new Rect(0,(Screen.height)-20,70,20),"Camera"))
		{
			if(lockCam == false)
			{
				lockCam=true;
			}
			else
			{
				lockCam = false;
			}
		}
			//BOUTON BATIMENT 1

		if(GUI.Button(new Rect(0,((Screen.height/4)*3),75,45), Batiments))
		{
		if(batiment1)
			{
				batiment1 = false;
			}

			else
			{
				batiment1 = true;
			}
			
		}

			//BOUTON BATIMENT2
			if(pSelect.GetComponent<PlayerBaseScript>().Batiment1ON)
			{
		if(GUI.Button(new Rect(0+75,((Screen.height/4)*3),75,45), Batiments2))
		{
			if(batiment2)
			{
				batiment2 = false;
			}
			
			else
			{
				batiment2 = true;
			}
			
				}}

		}}
	}

