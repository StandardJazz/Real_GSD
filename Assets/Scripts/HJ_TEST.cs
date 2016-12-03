using UnityEngine;
using System.Collections;

public class HJ_TEST : MonoBehaviour {
	
	public GameObject coinPrefab = null;
	public GameObject target = null;

	// Use this for initialization
	void Start () {
	

	}

	public RaycastHit2D GetMouseHit()									//raycast 정의	
	{
		Vector2 wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Ray2D ray = new Ray2D (wp, Vector2.zero);
		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction);

		return hit;
	}

	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0)) {
			RaycastHit2D hit = GetMouseHit ();

			if (hit.collider.gameObject.tag == "AngelTent") {

				//Instantiate (coinPrefab);

			}
		} else if (Input.GetMouseButtonUp (0)){


			RaycastHit2D hit = GetMouseHit ();
			if (hit.collider.gameObject.tag == "EvilTent" || hit.collider.gameObject.tag == "NeutralTent") {

				Instantiate (coinPrefab);

			}

		}



	


	}
}
