using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	private float hpBarLength;
	private float hpMax = 100;
	public float hpCurrent = 100;

	[SerializeField]
	private Texture2D fullLife;
	[SerializeField]
	private Texture2D midLife;
	[SerializeField]
	private Texture2D lowLife;

	public Vector3 wantedPos;

	public GameObject leGameObj;
	public Transform target;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		target = gameObject.transform;
		hpBarLength = (hpCurrent/hpMax)*100;
		if(Input.GetKeyDown("n"))
		   {
			hpCurrent -= 20;
		}
		if(Input.GetKeyDown("m"))
		   {
			hpCurrent += 20;
		}

		wantedPos = Camera.main.WorldToViewportPoint(target.position);
		

		if(hpCurrent <= 0.0f)
		{
			if(this.gameObject.name == "BaseJ2")
			   {
				Application.Quit();
			}
			Destroy(this.gameObject);
		}
	}


}
