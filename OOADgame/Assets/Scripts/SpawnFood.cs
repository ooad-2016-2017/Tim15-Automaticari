using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour {

    // Food Prefab
    public GameObject foodPrefab;

    // Use this for initialization
    void Start () {
        // Spawn food every 4 seconds, starting in 3
        InvokeRepeating("Spawn", 0, 4);
        
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

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector3 playerPos = rb.transform.position;
        Vector3 playerDirection = rb.transform.up;
 //   Quaternion playerRotation = rb.transform.rotation;
        float spawnDistance = 5;

        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;

        Instantiate(foodPrefab, spawnPos, Quaternion.identity);
        //Resources.Load(iconDragging.GetComponent<UISprite>().spriteName)
        //HRANA U KAMERI
        // Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(Screen.height/2, Screen.height), Camera.main.farClipPlane / 2));
        // Instantiate(foodPrefab, screenPosition, Quaternion.identity);

        //HRANA OKO STARTA
        //Instantiate(foodPrefab,
        //            new Vector2(Random.Range(17, 20), Random.Range(-10, 0)),
        //            Quaternion.identity); // default rotation
    }

    // Update is called once per frame
    void Update () {
		
	}
}
