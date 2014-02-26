using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class NetworkManager : MonoBehaviour {
	[SerializeField]
	Movement[]
	_Movement;

	[SerializeField]
	GUI_IG[]
	_Gui_IGs;



	//Prefab Base Joueur 1
	[SerializeField]
	Transform positionJ1;
	[SerializeField]
	Transform positionJ2;
	[SerializeField]
	Transform positionB1;
	[SerializeField]
	Transform positionB2;

	int _cnt = 0;

	[SerializeField]
	private GameObject _baseJ1_1;
	public GameObject BaseJ1_1 {
		get {
			return _baseJ1_1;
		}
		set {
			_baseJ1_1 = value;
		}
	}

			//Prefab Joueurs
	[SerializeField]
	private GameObject _Joueur1_1;
	public GameObject Joueur1_1 {
		get {
			return _Joueur1_1;
		}
		set {
			_Joueur1_1 = value;
		}
	}
	[SerializeField]
	private GameObject _joueur1_2;

	public GameObject joueur1_2 {
		get {
			return _joueur1_2;
		}
		set {
			_joueur1_2 = value;
		}
	}

	//Prefab Base Joueur 2
	[SerializeField]
	private GameObject _baseJ2_1;

	public GameObject BaseJ2_1 {
		get {
			return _baseJ2_1;
		}
		set {
			_baseJ2_1 = value;
		}
	}


	[SerializeField]
	private bool _isServer;
	public bool IsServer {
		get {
			return _isServer;
		}
		set {
			_isServer = value;
		}
	}

	private NetworkView _myNetworkView = null;
	public Dictionary<NetworkPlayer,GameObject> playerList = new Dictionary<NetworkPlayer, GameObject>();

	// Use this for initialization
	void Start () {
		_myNetworkView = this.gameObject.GetComponent<NetworkView>();

		Application.runInBackground = true;
		if(IsServer)
		{
			playerList = new Dictionary<NetworkPlayer, GameObject>();
			Network.InitializeSecurity();
			Network.InitializeServer(2,6600,true);
		}
		else
		{
			Network.Connect("127.0.0.1",6600);
		}
	}

	void OnPlayerConnected(NetworkPlayer player)
	{

		networkView.RPC("ConfigPlayer", RPCMode.AllBuffered, player, _cnt++);
	}
	
	// Update is called once per frame
	void Update () {
		print(Network.connections.Length);
		print(_cnt);
	}

	[RPC]
	void ConfigPlayer(NetworkPlayer player, int cnt){
		_Movement [cnt].monJoueur = player;
		_Gui_IGs[cnt].monJoueur = player;
		_Movement [cnt].RigidBodyNV.enabled = true;
		_Movement [cnt].networkView.enabled = true;
		_Movement [cnt].TransformNV.enabled = true;
	}

}
