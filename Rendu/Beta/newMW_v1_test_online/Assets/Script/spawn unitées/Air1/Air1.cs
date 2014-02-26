using UnityEngine;
using System.Collections;

public class Air1 : MonoBehaviour {
	
	private int tempsSpawn = 10;
	private int _alliance;
	
	public int alliance {
		get {
			return _alliance;
		}
		set {
			_alliance = value;
		}
	}
	private GameObject minion_Air_v1;
	[SerializeField]
	private GameObject spawn_Air_1;
	
	private bool isTiming = false;
	private float timer;
	
	// Use this for initialization
	void Start () {
		isTiming = true;
		timer = tempsSpawn;
	}
	
	// Update is called once per frame
	void Update () {
		if(isTiming)
		{
			timer -= Time.deltaTime;
			
			if(timer<=0)
			{
				GameObject minions4_1J1;
				
				timer = tempsSpawn;
				if(_alliance==1)
				{
					minions4_1J1 = (GameObject) Instantiate(Resources.Load("UniteeAir1"),new Vector3(gameObject.transform.position.x+1,gameObject.transform.position.y, gameObject.transform.position.z-15), Quaternion.identity);
					
				}
				else
				{
					minions4_1J1 = (GameObject) Instantiate(Resources.Load("UniteeAir1"),new Vector3(gameObject.transform.position.x+1,gameObject.transform.position.y, gameObject.transform.position.z+15), Quaternion.identity);
				}
				
				minions4_1J1.AddComponent<Rigidbody>();
				minions4_1J1.rigidbody.mass = 1000;
				minions4_1J1.AddComponent<BoxCollider>();
				minions4_1J1.GetComponent<Rigidbody>().isKinematic = true;
				minions4_1J1.AddComponent<NavMeshAgent>();
				minions4_1J1.AddComponent<MoveJ1>();
				minions4_1J1.GetComponent<MoveJ1>().alliance = _alliance;
				
				minions4_1J1.AddComponent<UIinfo>();
				minions4_1J1.GetComponent<UIinfo>().typeUnite = 4;
				minions4_1J1.AddComponent<UIAttack>();
				
				
				
			}
		}
		
	}
}
