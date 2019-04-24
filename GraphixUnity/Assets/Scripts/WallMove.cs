using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallMove : MonoBehaviour {

	public Slider slider;

	/// <summary>
	/// Update WallMove and make uv offset using slider
	/// </summary>
	void Update ()
	{
		// Create additional offset
		Vector2 offset = Vector2.zero;
		offset.y = -slider.value * Time.deltaTime;

		// Set Texture Offset using previous texture offset and offset
		Vector2 textureOffset = GetComponent<Renderer>().material.GetTextureOffset("_DetailAlbedoMap");
		GetComponent<Renderer>().material.SetTextureOffset("_DetailAlbedoMap", textureOffset + offset);
	}
}
