using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartLevel : MonoBehaviour {

	public Button restart;

	void Start()
	{
		Button btn = restart.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("Restart the current level");
		ScoreScript.scoreValue = 0;
		Application.LoadLevel ("space");

	}
}
