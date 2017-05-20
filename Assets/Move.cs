using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public Transform target;
	private AstarAI aStarAI;
	private AILerp aILerp;

	// Use this for initialization
	void Start () {
		aStarAI = GetComponent<AstarAI> ();
		aILerp = GetComponent<AILerp> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Click ();
	}

	void Click () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				Transform destination = hit.transform.gameObject.transform;

				Debug.Log (hit.transform.gameObject.transform);
				//aStarAI.targetPosition = destination;
				aILerp.target = destination;
			}
		}
	}
}
