using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNubes : MonoBehaviour {

	public GameObject[] nubes;
	public float distancia;
	public float supY;
	public float infY;
	private float ultimaNube;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > (ultimaNube + distancia))
        {
            Generar();
        }
			
	}

	void Generar(){
		Vector3 pos = new Vector3 (Random.Range(transform.position.x, transform.position.x+1), Random.Range (infY, supY), transform.position.z);
		ultimaNube = transform.position.x;
		Instantiate (nubes[Random.Range (0, nubes.Length)], pos, Quaternion.identity);
		

}
}
