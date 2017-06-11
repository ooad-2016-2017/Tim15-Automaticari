using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScoreScript : MonoBehaviour {
    Text score;
    // Use this for initialization
    void Start () {
        score = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        score.text = "Your score is: " + ScoreScript.scoreValue;
    }
}
