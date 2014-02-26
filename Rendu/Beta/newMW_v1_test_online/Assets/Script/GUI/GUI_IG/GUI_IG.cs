using UnityEngine;
using System.Collections;

public class GUI_IG : MonoBehaviour {

	private bool _bat1;
	public bool bat1 {
		get {
			return _bat1;
		}
		set {
			_bat1 = value;
		}
	}
	
	private NetworkPlayer _monJoueur;
	public NetworkPlayer monJoueur {
		get {
			return _monJoueur;
		}
		set {
			_monJoueur = value;
		}
	}

	private bool _bat2;
	public bool bat2 {
		get {
			return _bat2;
		}
		set {
			_bat2 = value;
		}
	}

	private bool _bat3;
	public bool bat3 {
		get {
			return _bat3;
		}
		set {
			_bat3 = value;
		}
	}

	private bool _bat4;
	public bool bat4 {
		get {
			return _bat4;
		}
		set {
			_bat4 = value;
		}
	}

	private int _wichOne;

	public int WichOne {
		get {
			return _wichOne;
		}
		set {
			_wichOne = value;
		}
	}

	Vector3 _targetPoint;
	public Vector3 TargetPoint {
		get {
			return _targetPoint;
		}
		set {
			_targetPoint = value;
		}
	}
	bool _wantToBuild = false;
	public bool WantToBuild {
		get {
			return _wantToBuild;
		}
		set {
			_wantToBuild = value;
		}
	}
	bool m_lockCam;
	public bool M_lockCam {
		get {
			return m_lockCam;
		}
		set {
			m_lockCam = value;
		}
	}

	int _allianceForNextBuiding = -1;

	[SerializeField]
	int alliance;
	bool bat1ON = false;
	bool bat2ON = false;
	bool bat3ON = false;
	[SerializeField]
	private Texture2D batiments;


	[SerializeField]
	private GameObject Batiment_Infanterie_1;
	[SerializeField]
	private GameObject Batiment_2;
	[SerializeField]
	private GameObject Batiment_3;
	[SerializeField]
	private GameObject Batiment_4;
	// Use this for initialization
	void Start () {
		bat1 = false;
		bat2 = false;
		bat3 = false;
		bat4 = false;
		_wantToBuild = false;
		_wichOne = 0;
	}

	void Update()
	{

		if(Input.GetMouseButtonDown(0) && Network.isClient && Network.player == monJoueur)
		{
			Debug.Log("Avant WichOne, alliance : " + alliance);

		if(_wichOne != 0)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitdist;
			if (Physics.Raycast(ray, out hitdist)) {
				_targetPoint = new Vector3(hitdist.point.x,0,hitdist.point.z);	
			}
				networkView.RPC("createBatiment",RPCMode.Server, Network.player, _wichOne, _targetPoint, alliance);
				
				Debug.Log("Mon alliance est : " + alliance);
				if(WichOne == 1)
				{
					bat1ON = true;
				}
				if(WichOne == 2)
				{
					bat2ON = true;
				}
				if(WichOne == 3)
				{
					bat3ON = true;
				}
				if(WichOne == 4)
				{

				}
			_wichOne = 0;

		}
		}
		if(_wantToBuild == true)
		{

			Creer(WichOne, _targetPoint, Network.player);
			_wichOne = 0;
			_wantToBuild = false;
		}
	}

	void OnGUI()
	{
		//GUI BOX
		if(Network.isClient && Network.player == monJoueur)
		{
			GUI.Box(new Rect(0,(Screen.height/4)*3,Screen.width,Screen.height/4),"");
			//GUI BOUTTON
			//BOUTON CAMLOCK
			//BOUTON BATIMENT 1
			
			if(GUI.Button(new Rect(0,((Screen.height/4)*3),75,45), batiments))
			{
				_wichOne = 1;
				bat1 = true;

			}
			
			//BOUTON BATIMENT2
			if(bat1ON)
			{
				if(GUI.Button(new Rect(0+75,((Screen.height/4)*3),75,45), batiments))
				{
					_wichOne = 2;
					bat2 = true;
				}
			}
			if(bat2ON)
			{
				if(GUI.Button(new Rect(0+75+75,((Screen.height/4)*3),75,45), batiments))
				{
					_wichOne = 3;
					bat3 = true;
				}
			}
			if(bat3ON)
			{
				if(GUI.Button(new Rect(0+75+75+75,((Screen.height/4)*3),75,45), batiments))
				{
					_wichOne = 4;
				}
			}
		}
	}//end script gui

	void Creer(int batiment, Vector3 position, NetworkPlayer player)
	{
		if(batiment == 1)
		{
			GameObject batiment1v1 =(GameObject) Instantiate(Batiment_Infanterie_1,position , Quaternion.identity);
			batiment1v1.AddComponent<unitee_terre_v1>();
			batiment1v1.GetComponent<unitee_terre_v1>().alliance = _allianceForNextBuiding;
			_allianceForNextBuiding = -1;
				
		}
		if(batiment == 2)
		{
			GameObject batiment2 =(GameObject) Instantiate(Batiment_2,position , Quaternion.identity);
			batiment2.AddComponent<Unitee_Tank_1>();
			batiment2.GetComponent<Unitee_Tank_1>().alliance = _allianceForNextBuiding;
			_allianceForNextBuiding = -1;
		}
		if(batiment == 3)
		{
			GameObject batiment3 =(GameObject) Instantiate(Batiment_3,position , Quaternion.identity);
			batiment3.AddComponent<AA1>();
			batiment3.GetComponent<AA1>().alliance = _allianceForNextBuiding;
			_allianceForNextBuiding = -1;
		}
		if(batiment == 4)
		{
			GameObject batiment4 =(GameObject) Instantiate(Batiment_4,position , Quaternion.identity);
			batiment4.AddComponent<Air1>();
			batiment4.GetComponent<Air1>().alliance = _allianceForNextBuiding;
			_allianceForNextBuiding = -1;
		}
		_wantToBuild = false;
	}



	[RPC]
	void setAlliance(NetworkPlayer player, int allianceServ)
	{
		alliance = allianceServ;
	}
	[RPC]
	void createBatiment(NetworkPlayer player, int batiment, Vector3 target, int alliance)
	{
		WichOne = batiment;
		_targetPoint = target;
		_wantToBuild = true;
		_allianceForNextBuiding = alliance;

		if(Network.isServer)
			networkView.RPC("createBatiment",RPCMode.Others, Network.player, _wichOne, _targetPoint, alliance);
	}

	[RPC]
	void Bat1(NetworkPlayer player,int  ForNextBuiding, Vector3 positionb1)
	{

		if(Network.isServer)
			networkView.RPC("Bat1",RPCMode.Others, Network.player, ForNextBuiding, positionb1);
	}
}
