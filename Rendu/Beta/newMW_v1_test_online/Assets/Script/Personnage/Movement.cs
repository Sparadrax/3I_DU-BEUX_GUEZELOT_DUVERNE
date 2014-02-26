using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	GameObject leJoueur;
	float destinationDistance;
	public float DestinationDistance {
		get {
			return destinationDistance;
		}
		set {
			destinationDistance = value;
		}
	}
	float moveSpeed;
	public float MoveSpeed {
		get {
			return moveSpeed;
		}
		set {
			moveSpeed = value;
		}
	}

	bool _already;
	public bool already {
		get {
			return _already;
		}
		set {
			_already = value;
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

	private Transform myTransform;
	private Vector3 destinationPosition;
	[SerializeField]
	Transform _transformPlayer;
	[SerializeField]
	NetworkView _rigidBodyNV;
	public NetworkView RigidBodyNV {
		get {
			return _rigidBodyNV;
		}
		set {
			_rigidBodyNV = value;
		}
	}
	[SerializeField]
	NetworkView _transformNV;

	public NetworkView TransformNV {
		get {
			return _transformNV;
		}
		set {
			_transformNV = value;
		}
	}

	[SerializeField]
	Rigidbody _rigidBody;
	public Rigidbody rigidBody {
		get {
			return _rigidBody;
		}
		set {
			_rigidBody = value;
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
	bool reclic;

	public bool Reclic {
		get {
			return reclic;
		}
		set {
			reclic = value;
		}
	}

	Vector3 _destination;
	private Ray position;
	private bool _wantToMove = false;
	// Use this for initialization
	void Start () {
		myTransform = transform;
		destinationPosition = myTransform.position;
		leJoueur = this.gameObject;
		print("le network player est : " + monJoueur);
		already = false;
		reclic = false;
	}
	
	// Update is called once per frame
	void Update () {
		print(leJoueur.name);

		print("mon network est : " + Network.player + " et mon joueur est : " + monJoueur);
		if(Input.GetMouseButtonDown(1) && Network.isClient && Network.player == monJoueur)
		{
			print("update");
			PlayerMovement();
			networkView.RPC("PlayerWantToMove",RPCMode.Server,Network.player, _targetPoint);
			reclic = true;

		}
	}
	void FixedUpdate()
	{
		if(_wantToMove)
		{
			if(already == false || reclic == true)
			{
				reclic = false;
				already = true;
			}
			playerMovementForReal(_targetPoint, Network.player);
		}
	}

	[RPC]
	void PlayerWantToMove(NetworkPlayer player, Vector3 pos)
	{
		print("want to move");
		_wantToMove = true;
		_targetPoint = pos;
		if(Network.isServer)
			networkView.RPC("PlayerWantToMove",RPCMode.Others, player, pos);
	}


	void PlayerMovement()
	{
		Plane playerPlane = new Plane(Vector3.up, myTransform.position);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float hitdist = 0.0f;
		if (playerPlane.Raycast(ray, out hitdist)) {
			_targetPoint = ray.GetPoint(hitdist);	
			}
	}

	void playerMovementForReal(Vector3 targetPoint, NetworkPlayer player)
	{
		Vector3 destinationPosition = targetPoint;
		destinationDistance = Vector3.Distance(destinationPosition, myTransform.position);
		Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
		myTransform.rotation = targetRotation;
		if(destinationDistance < .5f){	
			moveSpeed = 0;
			print("wannamove = 0");
			_wantToMove = false;
			already = false;
		}
		else if(destinationDistance > .5f){
			moveSpeed = 10;
		}

		if(destinationDistance > .5f){

			myTransform.position = Vector3.MoveTowards(myTransform.position, destinationPosition, moveSpeed * Time.deltaTime);

		
		}
	}


	void PlayerMovementStop()
	{

	}
}
