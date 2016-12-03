using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public float speed;
	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (target) 
		{
			transform.position = Vector2.MoveTowards (transform.position, target.position, Time.deltaTime * speed);
		


			if (Vector2.Distance (transform.position, target.position) < 0.1f) 
			{
				target = null;
				gameObject.SetActive (false);
			}
		}

	}

	/*
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (!isEnemy) 
		{
			if (coll.tag == "EvilTent" || coll.tag == "NeutralTent") 
			{
				target = null;
				gameObject.SetActive (false);
			}
		}
		else
		{
			if (coll.tag == "AngelTent") 
			{
				target = null;
				gameObject.SetActive (false);
			}
		}

	}
	*/
}
