using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocilacao : MonoBehaviour {


	private float tempo = 0;

	void Start () {

	}

	void Update () {

		tempo += Time.deltaTime;

		//float y = 5 * Mathf.Sin (tempo); Se quiser uma maior amplitude do movimento vertical
		float y = 2 * Mathf.Sin (tempo);

		transform.position = new Vector2 (-2,y);
	}
}