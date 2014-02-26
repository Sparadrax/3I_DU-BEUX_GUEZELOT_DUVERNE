using UnityEngine;
using System.Collections;

public class Unitee_Tank_1 : MonoBehaviour {

	[SerializeField]
	int tempspawn = 10;
	private int _alliance;

	public int alliance {
		get {
			return _alliance;
		}
		set {
			_alliance = value;
		}
	}

	private GameObject minion_tank_v1;
	[SerializeField]
	private GameObject spawn_tank_1;

	private bool isTiming = false;
	private float timer;

	// Use this for initialization
	void Start () {
		isTiming = true;
		timer = tempspawn;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isTiming)
		{
			timer -= Time.deltaTime;

			if(timer<=0)
			{
				GameObject minions2_1J1;

				timer = tempspawn;
				if(_alliance==1)
				{
				minions2_1J1 = (GameObject) Instantiate(Resources.Load("MinionTank"),new Vector3(gameObject.transform.position.x+1,gameObject.transform.position.y, gameObject.transform.position.z-15), Quaternion.identity);
				
				}
				else
				{
				minions2_1J1 = (GameObject) Instantiate(Resources.Load("MinionTank"),new Vector3(gameObject.transform.position.x+1,gameObject.transform.position.y, gameObject.transform.position.z+15), Quaternion.identity);
				}

				minions2_1J1.AddComponent<Rigidbody>();
				minions2_1J1.rigidbody.mass = 1000;
				minions2_1J1.AddComponent<BoxCollider>();
				minions2_1J1.GetComponent<Rigidbody>().isKinematic = true;
				minions2_1J1.AddComponent<NavMeshAgent>();
				minions2_1J1.AddComponent<MoveJ1>();
				minions2_1J1.GetComponent<MoveJ1>().alliance = _alliance;

				minions2_1J1.AddComponent<UIinfo>();
				minions2_1J1.GetComponent<UIinfo>().typeUnite = 2;
				minions2_1J1.AddComponent<UIAttack>();

					
				
			}
		}

	}
}
