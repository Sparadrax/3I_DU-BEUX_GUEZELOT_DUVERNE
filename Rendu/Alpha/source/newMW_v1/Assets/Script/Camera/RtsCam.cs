using UnityEngine;
using System.Collections;

public class RtsCam : MonoBehaviour {

	[SerializeField]
	private Transform target;
	private RaycastHit hit;
	private GameObject J1;
	private GameObject J2;
	public Transform Target {
		get {
			return target;
		}
		set {
			target = value;
		}
	}

	private int largeur = 5;
	private int moveSpeed = 250;

	// Use this for initialization
	void Start () {
		J1 = GameObject.Find("Player1");
		J2 = GameObject.Find("Player2");

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(ray, out hit, 100))
		   {
				string nameJ = "rienSelectionner";
				if(hit.rigidbody != null)
				{
				nameJ = hit.rigidbody.name;
				}

			if(nameJ=="Player1")
			{
				J1.GetComponent<MovementClick>().IsSelected = true;
					J2.GetComponent<MovementClickj2>().IsSelected = false;
			}
			if(nameJ=="Player2")
			{
				J1.GetComponent<MovementClick>().IsSelected = false;
				J2.GetComponent<MovementClickj2>().IsSelected = true;
			}

		}
		}
	var translation = Vector3.zero;
	
		if(GetComponent<GUI_InGame_j1>().m_lockCam)
		{
			translation = new Vector3(target.transform.position.x+15,target.transform.position.y+60,target.transform.position.z);
			camera.transform.position = translation;

			/*camera.transform.position.x = target.transform.position.x;
				camera.transform.position.y = target.transform.position.y- 50; */
		}
		else
		{
	if(Input.GetMouseButton(2))
		{

			translation += new Vector3(-Input.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime,0,Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime);
			
			camera.transform.position += translation;
		}
			
	else
		{
			
			if(Input.mousePosition.x <largeur)
			{

				translation += Vector3.forward * -moveSpeed * Time.deltaTime;

			}
			
			if(Input.mousePosition.x >= Screen.width - largeur)
			{
				translation += Vector3.forward * moveSpeed * Time.deltaTime;
					
			}
			
			if(Input.mousePosition.y < largeur)	
			{

				translation += Vector3.right * moveSpeed * Time.deltaTime;
			}
			
			if(Input.mousePosition.y > Screen.height - largeur)	
			{
				translation += Vector3.right * -moveSpeed * Time.deltaTime;

			}
		camera.transform.position += translation;
	
	}

		}
		}



	}
