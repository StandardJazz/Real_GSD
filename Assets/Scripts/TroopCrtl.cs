using UnityEngine;
using System.Collections;

public class TroopCrtl : MonoBehaviour {



	float troopSpeed = 5.0f;
	// Use this for initialization
	void Start () {
		

	
	}

	// Update is called once per frame

		void Update () {
		if (GameObject.Find ("Line")==true) {
				Debug.Log ("하하하하");
				
			//	Vector2 dir = (Camera.main.ScreenToWorldPoint (Input.mousePosition) - GameObject.Find ("Troop").transform.position);
			//	GetComponent<Transform> ().transform.Translate (dir.normalized * troopSpeed * Time.deltaTime);
			}
		}
		
}
