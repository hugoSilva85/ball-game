using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticBall : MonoBehaviour {
	
	public GameObject gameOverBackGround;

	void Start () {
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag != gameObject.tag) {
			Destroy (other.gameObject);

			EndGame ();

			//GameOverScript gameOver = new GameOverScript( );
			//gameOver.EndGame ();	
					
			}
		}

	public void EndGame () {
		gameOverBackGround.SetActive(true);
		//gambiarra corrigir pq isso tem que criar referencia para cada bola statica
	}
	}

