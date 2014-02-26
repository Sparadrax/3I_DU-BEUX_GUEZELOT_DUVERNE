using UnityEngine;
using System.Collections;

public class unitee_terre_v1 : MonoBehaviour {
	[SerializeField]
	int tempspawn = 10;

	private GameObject minion_terre_v1;
	[SerializeField]
	private GameObject spawn_terre_1;

	private int _alliance;

	public int alliance {
		get {
			return _alliance;
		}
		set {
			_alliance = value;
		}
	}

	private bool isTiming = false;
	private float timer;

	// Use this for initialization
	void Start () {
		isTiming = true;
		timer = tempspawn;

	}


	// Update is called once per frame
	void FixedUpdate () {
	
		if(isTiming)
		{
			timer -= Time.deltaTime;

			if(timer<=0)
			{
				GameObject minions1_1J1;
				timer = tempspawn;
				if(_alliance==1)
				{
					minions1_1J1 = (GameObject) Instantiate(Resources.Load("MinionTerre1"),new Vector3(gameObject.transform.position.x,gameObject.transform.position.y+0.90F, gameObject.transform.position.z-10), Quaternion.identity);
				}
				else
				{
					minions1_1J1 = (GameObject) Instantiate(Resources.Load("MinionTerre1"),new Vector3(gameObject.transform.position.x,gameObject.transform.position.y+0.90F, gameObject.transform.position.z+10), Quaternion.identity);

				}
				minions1_1J1.AddComponent<Rigidbody>();
				minions1_1J1.GetComponent<Rigidbody>().isKinematic = true;
				minions1_1J1.rigidbody.mass = 1000;

				minions1_1J1.AddComponent<NavMeshAgent>();
				minions1_1J1.AddComponent<MoveJ1>();
				minions1_1J1.GetComponent<MoveJ1>().alliance = _alliance;

				minions1_1J1.AddComponent<UIinfo>();
				minions1_1J1.GetComponent<UIinfo>().typeUnite = 1;
				minions1_1J1.AddComponent<UIAttack>();
			}

		}
	}
}

