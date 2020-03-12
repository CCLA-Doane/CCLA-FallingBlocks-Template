using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour {

	public float destroyT= 2.0f;
	void Start ()
	{
		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
	}


	// Update is called once per frame
	void Update () {

		Destroy(gameObject, destroyT);
	}

}