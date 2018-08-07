using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOffset : MonoBehaviour {

	private Renderer renderer;

	private void Awake()
	{
		renderer = GetComponent<Renderer>();
	}
	// Update is called once per frame
	void Update ()
	{
		renderer.material.SetTextureOffset("_MainTex", transform.position);
	}
}
