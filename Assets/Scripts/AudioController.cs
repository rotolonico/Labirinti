using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting.APIUpdating;

public class AudioController : MonoBehaviour {

	public AudioClip FailClip;
	public AudioClip WinClip;
	public AudioSource MusicFailSource;
	public AudioSource MusicWinSource;
	bool played;
	bool played2;
	private bool doThis = true;
	public GameObject player;
	private int nextSceneIndex;
	private readonly Vector2 emptyVector2 = new Vector2(0,0);

	// Use this for initialization
	void Start () {
		MusicFailSource.clip = FailClip;
		MusicWinSource.clip = WinClip;
	}



	private void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "wall")
		{
			if (doThis)
			{
				PlayerController.move = false;
				PlayerController.speed = 3;
				if (PlayerController.moveVelocity == emptyVector2)
				{
					PlayerController.size = false;
				}
				else
				{
					PlayerController.size = true;
				}
				if (!MusicFailSource.isPlaying && !played)
				{
					MusicFailSource.Play();
					played = true;
				}

				if (!MusicFailSource.isPlaying && played)
				{
					SceneManager.LoadScene(Application.loadedLevel);
					played = false;
					PlayerController.move = true;
					PlayerController.size = false;
					PlayerController.speed = 7;
					doThis = false;
				}

			}
		}

		if (other.gameObject.tag == "end")
		{
			if (doThis)
			{
				PlayerController.move = false;
				PlayerController.speed = 0;
				if (!MusicWinSource.isPlaying && !played2)
				{
					MusicWinSource.Play();
					played2 = true;

				}

				if (!MusicWinSource.isPlaying && played2)
				{
					SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
					played2 = false;
					PlayerController.move = true;
					PlayerController.speed = 7;
					doThis = false;
				}
			}
		}

	}

}
