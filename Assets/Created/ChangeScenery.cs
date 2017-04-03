using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenery : MonoBehaviour {

	public GameObject plane;

	public Texture[] textures;
	private int count = 0;

	private void OnMouseDown() {
		count++;
		if( count > textures.Length) {
			count = 0;
		}
		plane.GetComponent<Renderer>().material.mainTexture = textures[count];

	}
}

