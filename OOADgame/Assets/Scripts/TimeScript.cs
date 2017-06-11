using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
    public static int timeValue = 50;
    Text time;

	// Use this for initialization
	void Start () {
        time = GetComponent<Text>();
        InvokeRepeating("Decrement", 1, 1);
    }

    void Decrement()
    {
        timeValue--;
    }
	
	// Update is called once per frame
	void Update () {
        time.text = "Time " + timeValue;
        if(timeValue <=0 )
        {
            SceneManager.LoadScene("nekanova");
        }
        
    }
}
