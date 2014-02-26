using UnityEngine;
using System.Collections;

public class UIinfo : MonoBehaviour {
	[SerializeField]
	private int _life = 100;
	private int _damage;
	private int _typeUnite;

	public int typeUnite {
		get {
			return _typeUnite;
		}
		set {
			_typeUnite = value;
		}
	}

	public int life {
		get {
			return _life;
		}
		set {
			_life = value;
		}
	}

	public int damage {
		get {
			return _damage;
		}
		set {
			_damage = value;
		}
	}


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
