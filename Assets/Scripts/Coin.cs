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
		}
	}
}
