using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public static float speed = 7;
	private Rigidbody2D rb;
	public static Vector2 moveVelocity;
	public static bool move = true;
	public static bool size = false;
	private Vector2 moveInput;
	private Vector2 mousePosition;
	private float zAxis = 2f;
	public static bool space;
	public static bool flip;
	private bool flip2 = true;
	SpriteRenderer m_SpriteRenderer;
	private int counter;
	


	
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		m_SpriteRenderer = GetComponent<SpriteRenderer>();
		m_SpriteRenderer.color = Color.green;
	}
	
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.C))
		{
			counter += 1;
		}

		if (counter == 1)
		{
			m_SpriteRenderer.color = Color.blue;
		}
		if (counter == 2)
		{
			m_SpriteRenderer.color = Color.red;
		}
		if (counter == 3)
		{
			m_SpriteRenderer.color = Color.yellow;
		}
		if (counter == 4)
		{
			m_SpriteRenderer.color = Color.green;
		}
		if (counter == 5)
		{
			counter = 1;
		}

		moveVelocity = moveInput * speed;
		if (move)
		{
			moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
			if (space)
			{
				transform.position = mousePosition;
			}
		}
		
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetKey(KeyCode.Space) && !flip && flip2)
		{
			flip2 = false;
			space = true;
			flip = true;
		}
		if (Input.GetKey(KeyCode.Space) && flip && flip2)
		{
			flip2 = false;
			space = false;
			flip = false;
		}
		if (Input.GetKeyUp(KeyCode.Space))
		{
			flip2 = true;
		}
		
		if (size)
		{
			transform.localScale += new Vector3(-0.0232F, -0.0232F, 0F);
		}
	}

	void FixedUpdate()
	{
		rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
	}
			 
}
