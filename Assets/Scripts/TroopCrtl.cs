using UnityEngine;
using System.Collections;

public class TroopCrtl : MonoBehaviour {

	private Vector2 StartPosition;
	private Vector2 EndPosition;

	private GameObject startObj = null;
	private GameObject endObj= null;

	private float speed = 3f;
	private float startTime; 
	private float distanceLength;




	// Use this for initialization
	void Start () {


		startTime = Time.time;

		distanceLength = Vector2.Distance (StartPosition, EndPosition);
	}

	public RaycastHit2D GetMouseHit()									//raycast 정의	
	{
		Vector2 wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Ray2D ray = new Ray2D (wp, Vector2.zero);
		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction);
		return hit;
	}

	// Update is called once per frame

		public void Update () {


		//ray hit -> object find

		if (Input.GetMouseButtonDown (0)) {
			
			RaycastHit2D hit = GetMouseHit ();

			if (hit.collider.gameObject == gameObject) {
				startObj = gameObject;
			}

		} else if (Input.GetMouseButtonUp (0)) {
			
			RaycastHit2D hit = GetMouseHit ();

			if (hit.collider.gameObject == gameObject) {
				endObj = gameObject;
			}
		}


		StartPosition = startObj.transform.position;
		EndPosition = endObj.transform.position;


		float distCovered = (Time.time - startTime) * speed;
		float franJourney = distCovered / distanceLength;
		transform.position = Vector2.Lerp (StartPosition, EndPosition, franJourney);



		}
		
}
