using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

    /// <summary>
    /// Add this class to create a pipe.
    /// </summary>

	void Start () {
		transform.position=new Vector3(transform.position.x,Random.Range(-0.9f,1.6f),0);
	}
	
	void Update () {

		if(!Bird.IsAlive || !Bird.IsStart)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity =Vector2.zero;
			return;
		}

		if(transform.position.x < -3.5f)
		{
			Reset();
		}
		gameObject.GetComponent<Rigidbody2D>().velocity =new Vector2(-1.2f,0);
	}

	public void Reset()
	{
		transform.position=new Vector3(2.5f,Random.Range(-0.9f,1.6f),0);
	}
}
