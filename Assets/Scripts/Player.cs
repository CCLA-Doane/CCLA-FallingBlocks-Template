using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float speed = 15f;
	public float mapWidth = 5f;

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate ()
	{
		float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

		Vector2 newPosition = rb.position + Vector2.right * x;

		newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

		rb.MovePosition(newPosition);

	}

	void OnCollisonEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "block")
		{
			gameOver();
			Debug.Log("Game OVER");
		}
	}

	public void gameOver()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

}
