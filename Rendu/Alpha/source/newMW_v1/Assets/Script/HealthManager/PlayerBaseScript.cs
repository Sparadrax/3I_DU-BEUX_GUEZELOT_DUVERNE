using UnityEngine;
using System.Collections;

public class PlayerBaseScript : MonoBehaviour {
	private bool _batiment1ON = false;
	private bool _batiment1_1ON = false;
	private bool _batiment2ON = false;
	private bool _batiment2_1ON = false;
	private bool _batiment3ON = false;
	private bool _batiment3_1ON = false;
	private bool _batiment4ON = false;
	private bool _batiment4_1ON = false;
	
	public bool Batiment1ON {
		get {
			return _batiment1ON;
		}
		set {
			_batiment1ON = value;
		}
	}

	public bool Batiment1_1ON {
		get {
			return _batiment1_1ON;
		}
		set {
			_batiment1_1ON = value;
		}
	}

	public bool Batiment2ON {
		get {
			return _batiment2ON;
		}
		set {
			_batiment2ON = value;
		}
	}

	public bool Batiment2_1ON {
		get {
			return _batiment2_1ON;
		}
		set {
			_batiment2_1ON = value;
		}
	}

	public bool Batiment3ON {
		get {
			return _batiment3ON;
		}
		set {
			_batiment3ON = value;
		}
	}

	public bool Batiment3_1ON {
		get {
			return _batiment3_1ON;
		}
		set {
			_batiment3_1ON = value;
		}
	}

	public bool Batiment4ON {
		get {
			return _batiment4ON;
		}
		set {
			_batiment4ON = value;
		}
	}

	public bool Batiment4_1ON {
		get {
			return _batiment4_1ON;
		}
		set {
			_batiment4_1ON = value;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
