using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public Slider slider;
    Animator animator = null;

	private float speed = 0;


	// Use this for initialization 
    void Start ()
    {
        animator = GetComponent<Animator>();
    }

	void Update()
	{
		if (speed != slider.value)
		{
			speed = slider.value;

			if (animator.parameterCount > 1)
			{
				// Set Walk Mod
				int walkID = animator.parameters[0].nameHash;
				animator.SetFloat(walkID, speed);

				// Set Run Mod
				float runSpeed = 1 + ((speed - 1) * 0.5f);
				runSpeed = Mathf.Clamp(runSpeed, 1.0f, 2.0f);

				int runID = animator.parameters[1].nameHash;
				animator.SetFloat(runID, runSpeed);
			}
		}
	}
}
