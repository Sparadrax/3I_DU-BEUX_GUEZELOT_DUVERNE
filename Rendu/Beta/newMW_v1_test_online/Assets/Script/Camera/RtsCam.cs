using UnityEngine;
using System.Collections;

public class RtsCam : MonoBehaviour {

	[SerializeField]
	private Transform target;
	private RaycastHit hit;

	int scroll;
	bool _canMoveUp = true;
	bool _canMoveDown = true;
	bool _canMoveRight = true;
	bool _cnMoveLeft = true;

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

	}
	
	// Update is called once per frame
	void Update () {

		/*if(Input.GetMouseButtonDown(0))
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
		}*/
	var translation = Vector3.zero;

		if (Input.GetAxis("Mouse ScrollWheel") > 0 && camera.transform.position.y > 42) // forward
		{
			translation += Vector3.up * -moveSpeed * Time.deltaTime;

			camera.transform.position += translation;
			scroll += 1;
		}
		if (Input.GetAxis("Mouse ScrollWheel") < 0 && camera.transform.position.y < 53) // back
		{
			scroll -= 1;
			translation -= Vector3.up * -moveSpeed * Time.deltaTime;

			camera.transform.position += translation;
		}
		if(Input.GetMouseButton(2))
		{

			translation += new Vector3(-Input.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime,0,Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime);
			
			camera.transform.position += translation;
		}
			
	else
		{
			if(camera.transform.position.x > 850)
			{
				_canMoveDown = false;
			}
			else
			{
				_canMoveDown = true;
			}
			if(camera.transform.position.x < 690)
			{
				_canMoveUp = false;
			}

			else
			{
				_canMoveUp = true;
			}
			if(camera.transform.position.z < 890)
			{
				_cnMoveLeft = false;
			}
			else
			{
				_cnMoveLeft = true;
			}
			if(camera.transform.position.z > 1510)
			{
				_canMoveRight = false;
			}
			else
			{
				_canMoveRight = true;
			}
			Debug.Log(camera.transform.position);
			if(Input.mousePosition.x <largeur && _cnMoveLeft)
			{

				translation += Vector3.forward * -moveSpeed * Time.deltaTime;
				
			}
			
			if(Input.mousePosition.x >= Screen.width - largeur && _canMoveRight)
			{
				translation += Vector3.forward * moveSpeed * Time.deltaTime;
					
			}
			
			if(Input.mousePosition.y < largeur && _canMoveDown)	
			{

				translation += Vector3.right * moveSpeed * Time.deltaTime;
			}
			
			if(Input.mousePosition.y > Screen.height - largeur && _canMoveUp)	
			{
				translation += Vector3.right * -moveSpeed * Time.deltaTime;

			}
		camera.transform.position += translation;
	
	}

		}



	}
