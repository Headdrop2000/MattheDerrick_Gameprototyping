using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {
    public GameObject wallPrefab;
    
	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnWall());
	}
	
	// Update is called once per frame
	void Update () {
       
	}


IEnumerator SpawnWall()
    {

        Instantiate(wallPrefab, transform.position, Quaternion.identity);
      


        yield return new WaitForSeconds(1);

        StartCoroutine(SpawnWall());



    }



}
