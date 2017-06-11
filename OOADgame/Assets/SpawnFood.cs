using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour {

    // Food Prefab
    public GameObject foodPrefab;

    // Use this for initialization
    void Start () {
        // Spawn food every 4 seconds, starting in 3
        InvokeRepeating("Spawn", 1, 5);
        
    }

    // Spawn one piece of food
    public void Spawn()
    {
        // x position between left & right border
        /*int x = (int)Random.Range(borderLeft.position.x,
                                  borderRight.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(borderBottom.position.y,
                                  borderTop.position.y);*/

        // Instantiate the food at (x, y)
        Instantiate(foodPrefab,
                    new Vector2(Random.Range(17, 20), Random.Range(-10, 0)),
                    Quaternion.identity); // default rotation
    }

    // Update is called once per frame
    void Update () {
		
	}
}
