using UnityEngine;
using System.Collections;

public class AE_PlayTest : MonoBehaviour {
	//public Vector3 targetPos;
	//public float speed;

	public Transform troop;
	public GameObject coinPrefab = null;


	LineRenderer line;






	void Start()
	{
		//targetPos -> 초기값 설정.

		//line 설정 
		line = new GameObject ("Line").AddComponent<LineRenderer> ();
		line.SetVertexCount (2);				//line cnt
		line.SetWidth (0.1f,0.1f);
		line.SetColors (Color.white, Color.white);
		line.SetPosition (0, transform.position);
		line.SetPosition (1, transform.position);
		line.material = new Material (Shader.Find ("Diffuse"));
		line.useWorldSpace = true;
		line.enabled = false;


	}

	public RaycastHit2D GetMouseHit()									//raycast 정의	
	{
		Vector2 wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Ray2D ray = new Ray2D (wp, Vector2.zero);
		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction);

		return hit;
	}

	// Update is called once per frame
	public void Update () 
	{
		

		if (Input.GetMouseButtonDown (0))
		{										//마우스를 눌렀을때

			RaycastHit2D hit = GetMouseHit ();

			if (hit.collider.gameObject == gameObject) 
			{
				line.enabled = true;

				//line이 활성화 (Once Confirm)	
			}
		}
		else if (Input.GetMouseButton (0)){ 										//Press mouse button (0)
			//ray cast notion

			RaycastHit2D hit = GetMouseHit ();

			if (hit.collider != null)
			{											//some collider working
				line.SetPosition (1, hit.point);
			}
												//create line
		} 
		else if (Input.GetMouseButtonUp(0)) {									//when mouse button up


			RaycastHit2D hit = GetMouseHit ();

			if (hit.collider.gameObject.tag == "EvilTent" || hit.collider.gameObject.tag == "NeutralTent") 
			{
				GameObject target =  hit.collider.gameObject;
				line.SetPosition (1,target.transform.position);	

				GameObject c = Instantiate (coinPrefab, transform.position, transform.rotation) as GameObject;
				c.transform.SetParent (troop);
				c.GetComponent<Coin> ().target = target.transform;

			} 
			else 
			{
				line.SetPosition (1, transform.position);	
				line.enabled = false;
			}

		}

		//float maxDistance = speed * Time.deltaTime;
		//transform.position = Vector3.MoveTowards (transform.position, targetPos, maxDistance);//출발점, 움직일곳, 속도




	}
}
