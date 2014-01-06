using UnityEngine;
using System.Collections;

public class unitee_terre_v1 : MonoBehaviour {
	[SerializeField]
	int tempspawn = 5;

	private GameObject minion_terre_v1;
	[SerializeField]
	private GameObject spawn_terre_1;

	private bool isTiming = false;
	private float timer;

	// Use this for initialization
	void Start () {
		isTiming = true;
		timer = tempspawn;

	}
	
	// Update is called once per frame
	void Update () {
	
		if(isTiming)
		{
			timer -= Time.deltaTime;
			Debug.Log(timer);
			if(timer<=0)
			{
				timer = tempspawn;
				GameObject minions1 = (GameObject) Instantiate(Resources.Load("MinionTerre1"),new Vector3(gameObject.transform.position.x+20,gameObject.transform.position.y+20, gameObject.transform.position.z), Quaternion.identity);
				BoxCollider myBoxcolider = minions1.AddComponent<BoxCollider>();
				Rigidbody myRigidBody = minions1.AddComponent<Rigidbody>();
				minions1.rigidbody.mass = 100;

			}
		}
	}
}
