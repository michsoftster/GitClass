﻿using UnityEngine;
using System.Collections;

public class RotateAndColor : MonoBehaviour 
{
	[Range(0.0f, 100.0f)]public float rotacion = 45.0f;
	[Range(1.0f, 10.0f)] public float tiempo = 1.0f;
	public Color[] colores;
	private MeshRenderer r;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine("RotateColor");
		r = this.GetComponent<MeshRenderer> ();


	}


    /*IEnumerator RotateColor()
    {     
        yield return new WaitForSeconds(5f);
        transform.Rotate(-5,0,-15);
        GetComponent<MeshRenderer>().material.color = new Color(0,0,1,1);
    }*/

	IEnumerator RotateColor()
	{
		while (true) {
			foreach (var color in colores) {
				yield return new WaitForSeconds (tiempo);
				transform.Rotate (0, rotacion, 0);
				r.material.color = color;
			}

		}
	}

}

