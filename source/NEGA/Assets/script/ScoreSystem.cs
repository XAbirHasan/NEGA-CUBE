using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {

	public static int score = 0;
	public Text scoreText;
	// Update is called once per frame
	void Update () {
		scoreText.text = score.ToString();
	}
}
