using UnityEngine;
using System.Collections;

public class UIAttack : MonoBehaviour {
	[SerializeField]
	private bool _attack = false;
	[SerializeField]
	private GameObject _target;
	[SerializeField]
	private float timer = 0.5f;

	public GameObject target {
		get {
			return _target;
		}
		set {
			_target = value;
		}
	}

	public bool attack {
		get {
			return _attack;
		}
		set {
			_attack = value;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(target != null)
		{
	if(_attack)
		{
				timer = timer-Time.deltaTime;
				if(timer<=0)
				{
					//////////////
					/// DEGATS UNITEES TERRES
					/// //////////
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 1 && target.gameObject.GetComponent<UIinfo>().typeUnite == 1)
					{
						target.GetComponent<UIinfo>().life -= 20;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 1 && target.gameObject.GetComponent<UIinfo>().typeUnite == 12)
					{
						target.GetComponent<UIinfo>().life -= 15;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 1 && target.gameObject.GetComponent<UIinfo>().typeUnite == 2)
					{
					target.GetComponent<UIinfo>().life -= 10;
					timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 1 && target.gameObject.GetComponent<UIinfo>().typeUnite == 22)
					{
						target.GetComponent<UIinfo>().life -= 7;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 1 && target.gameObject.GetComponent<UIinfo>().typeUnite == 3)
					{
						target.GetComponent<UIinfo>().life -= 15;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 1 && target.gameObject.GetComponent<UIinfo>().typeUnite == 32)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 1 && target.gameObject.GetComponent<UIinfo>().typeUnite == 4)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 1 && target.gameObject.GetComponent<UIinfo>().typeUnite == 42)
					{
						target.GetComponent<UIinfo>().life -= 5;
						timer = 0.5f;
					}


					//////////////
					/// DEGATS UNITEE TANK
					/// //////////
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 2 && target.gameObject.GetComponent<UIinfo>().typeUnite == 1)
					{
						target.GetComponent<UIinfo>().life -= 15;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 2 && target.gameObject.GetComponent<UIinfo>().typeUnite == 12)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 2 && target.gameObject.GetComponent<UIinfo>().typeUnite == 2)
					{
						target.GetComponent<UIinfo>().life -= 20;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 2 && target.gameObject.GetComponent<UIinfo>().typeUnite == 22)
					{
						target.GetComponent<UIinfo>().life -= 15;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 2 && target.gameObject.GetComponent<UIinfo>().typeUnite == 3)
					{
						target.GetComponent<UIinfo>().life -= 30;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 2 && target.gameObject.GetComponent<UIinfo>().typeUnite == 32)
					{
						target.GetComponent<UIinfo>().life -= 20;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 2 && target.gameObject.GetComponent<UIinfo>().typeUnite == 4)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 2 && target.gameObject.GetComponent<UIinfo>().typeUnite == 42)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}

					/////////////////
					/// DEGATS UNITEE ANTITANK
					/// /////////////
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 3 && target.gameObject.GetComponent<UIinfo>().typeUnite == 1)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 3 && target.gameObject.GetComponent<UIinfo>().typeUnite == 12)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 3 && target.gameObject.GetComponent<UIinfo>().typeUnite == 2)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 3 && target.gameObject.GetComponent<UIinfo>().typeUnite == 22)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 3 && target.gameObject.GetComponent<UIinfo>().typeUnite == 3)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 3 && target.gameObject.GetComponent<UIinfo>().typeUnite == 32)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 3 && target.gameObject.GetComponent<UIinfo>().typeUnite == 4)
					{
						target.GetComponent<UIinfo>().life -= 30;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 3 && target.gameObject.GetComponent<UIinfo>().typeUnite == 42)
					{
						target.GetComponent<UIinfo>().life -= 20;
						timer = 0.5f;
					}
				
					///////////////////
					/// DEGATS UNITEE AIR
					/// ///////////////
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 4 && target.gameObject.GetComponent<UIinfo>().typeUnite == 1)
					{
						target.GetComponent<UIinfo>().life -= 40;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 4 && target.gameObject.GetComponent<UIinfo>().typeUnite == 12)
					{
						target.GetComponent<UIinfo>().life -= 25;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 4 && target.gameObject.GetComponent<UIinfo>().typeUnite == 2)
					{
						target.GetComponent<UIinfo>().life -= 15;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 4 && target.gameObject.GetComponent<UIinfo>().typeUnite == 22)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 4 && target.gameObject.GetComponent<UIinfo>().typeUnite == 3)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 4 && target.gameObject.GetComponent<UIinfo>().typeUnite == 32)
					{
						target.GetComponent<UIinfo>().life -= 5;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 4 && target.gameObject.GetComponent<UIinfo>().typeUnite == 4)
					{
						target.GetComponent<UIinfo>().life -= 20;
						timer = 0.5f;
					}
					if(this.gameObject.GetComponent<UIinfo>().typeUnite == 4 && target.gameObject.GetComponent<UIinfo>().typeUnite == 42)
					{
						target.GetComponent<UIinfo>().life -= 10;
						timer = 0.5f;
					}
					else
					{

					}
				}
				if(target.GetComponent<UIinfo>().life <= 0)
				{
					Destroy(target);
					target = null;
				}
		}
		}
		else
		{
			this.gameObject.GetComponent<MoveJ1>().Agent.enabled = true;
			this.gameObject.GetComponent<MoveJ1>().Move = true;
			_attack = false;
		}
	}
}
