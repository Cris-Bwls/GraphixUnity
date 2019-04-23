using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallMove : MonoBehaviour {

	public Slider slider;

	// Update is called once per frame
	void Update ()
	{
		Vector2 offset = Vector2.zero;
		offset.y = -slider.value * Time.deltaTime;

		Vector2 textureOffset = GetComponent<Renderer>().material.GetTextureOffset("_DetailAlbedoMap");
		GetComponent<Renderer>().material.SetTextureOffset("_DetailAlbedoMap", textureOffset + offset);
	}
}
