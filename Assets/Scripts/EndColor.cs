using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndColor : MonoBehaviour {
	
	SpriteRenderer m_SpriteRenderer;
	private int counter; 

	void Start () {
		m_SpriteRenderer = GetComponent<SpriteRenderer>();
		m_SpriteRenderer.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C))
		{
			counter += 1;
		}

		if (counter == 1)
		{
			m_SpriteRenderer.color = Color.red;
		}
		if (counter == 2)
		{
			m_SpriteRenderer.color = Color.yellow;
		}
		if (counter == 3)
		{
			m_SpriteRenderer.color = Color.green;
		}
		if (counter == 4)
		{
			m_SpriteRenderer.color = Color.blue;
		}
		if (counter == 5)
		{
			counter = 1;
		}
	}
}
