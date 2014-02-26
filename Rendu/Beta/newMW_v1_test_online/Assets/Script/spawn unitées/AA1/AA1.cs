using UnityEngine;
using System.Collections;

public class AA1 : MonoBehaviour {

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
	private GameObject minion_AA_v1;
	[SerializeField]
	private GameObject spawn_AA_1;
	
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
				GameObject minions3_1J1;
				
				timer = tempsSpawn;
				if(_alliance==1)
				{
					minions3_1J1 = (GameObject) Instantiate(Resources.Load("UniteeAntiAir"),new Vector3(gameObject.transform.position.x+1,gameObject.transform.position.y, gameObject.transform.position.z-15), Quaternion.identity);
					
				}
				else
				{
					minions3_1J1 = (GameObject) Instantiate(Resources.Load("UniteeAntiAir"),new Vector3(gameObject.transform.position.x+1,gameObject.transform.position.y, gameObject.transform.position.z+15), Quaternion.identity);
				}
				
				minions3_1J1.AddComponent<Rigidbody>();
				minions3_1J1.rigidbody.mass = 1000;
				minions3_1J1.AddComponent<BoxCollider>();
				minions3_1J1.GetComponent<Rigidbody>().isKinematic = true;
				minions3_1J1.AddComponent<NavMeshAgent>();
				minions3_1J1.AddComponent<MoveJ1>();
				minions3_1J1.GetComponent<MoveJ1>().alliance = _alliance;
				minions3_1J1.AddComponent<UIinfo>();
				minions3_1J1.GetComponent<UIinfo>().typeUnite = 3;
				minions3_1J1.AddComponent<UIAttack>();
				
				
				
			}
		}

	}
}
