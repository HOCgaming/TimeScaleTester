using UnityEngine;
using System.Collections;

public class CollisionControler : MonoBehaviour {

	public GameObject pillar;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameObject.transform.position.y < -20)
		{
			Application.Quit();
		}
	}

	void OnCollisionEnter(Collision boom) 
	{
		Destroy (pillar);

	}

}
