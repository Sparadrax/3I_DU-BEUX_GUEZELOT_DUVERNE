using UnityEngine;
using System.Collections;

public class MoveJ1 : MonoBehaviour {

	private NavMeshAgent agent;

	public NavMeshAgent Agent {
		get {
			return agent;
		}
		set {
			agent = value;
		}
	}

	[SerializeField]
	private GameObject BaseEnnemy;
	private int _alliance;

	public int alliance {
		get {
			return _alliance;
		}
		set {
			_alliance = value;
		}
	}

	private float range = 30.0f;
	private float distance;
	private bool move = true;

	public bool Move {
		get {
			return move;
		}
		set {
			move = value;
		}
	}

	private bool cooldown = false;
	private bool attack = false;
	private float timer = 1.0f;
		



	void Start() {
					
	}

	void Update() {
		if(move)
		{
		agent = GetComponent<NavMeshAgent>();
		if(_alliance == 1)
			{
				BaseEnnemy = GameObject.Find("BaseJ2");
			}
		if(_alliance == 2)
			{
				BaseEnnemy = GameObject.Find("BaseJ1");
			}

			//agent.destination = BaseEnnemy.transform.position;
			agent.SetDestination(BaseEnnemy.transform.position);
			distance = Vector3.Distance(BaseEnnemy.transform.position, this.gameObject.transform.position);

			if(distance < range)
			{
				agent.Stop();
				attack = true;
				move = false;

			}
		}
		if(attack)
		{
			timer -= Time.deltaTime;
			if(timer <= 0.0f)
			{


			BaseEnnemy.GetComponent<HealthBar>().hpCurrent -=10;
				timer = 1;
			}
		}



	}
	void OnTriggerEnter(Collider other)
	{
		string name = other.gameObject.name;
		Debug.Log(other.gameObject.name);
			if(other.gameObject.GetComponent<MoveJ1>()._alliance != this._alliance && name !="BASEJ1" && name != "Player1")
			{
				

				
				if(this.gameObject.GetComponent<UIAttack>().target == null)
			{
				move = false;
				this.gameObject.GetComponent<UIAttack>().target = other.gameObject;
				this.gameObject.GetComponent<UIAttack>().attack = true;
				agent.enabled = false;

			}
				
			}



	}
	void OnTriggerStay(Collider other)
	{

	}



}