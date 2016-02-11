using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

    /// <summary>
    /// Add this clase to create a bird player.
    /// </summary>

    Animator anim;

    public GameObject Hit;
	public GameObject Die;

	public static int Points=0;

	public static bool IsAlive =true;
	public static bool IsStart=false;
	
	void Start () {
		anim=gameObject.GetComponent<Animator>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!IsAlive)
            return;
        if (other.tag == "AddScore")
        {
            Points++;
            other.GetComponent<AudioSource>().Play();
            return;
        }
        IsAlive = false;
        Die.GetComponent<AudioSource>().Play();
        Hit.GetComponent<AudioSource>().Play();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!IsAlive)
            return;

        IsAlive = false;
        Hit.GetComponent<AudioSource>().Play();
    }

    void Update () {

		if(!IsStart)
		{
			gameObject.GetComponent<Rigidbody2D>().Sleep();
			if(Input.GetMouseButtonDown(0))
			{
				IsStart=true;
				gameObject.GetComponent<Rigidbody2D>().WakeUp();
			}else
			{
				return;
			}
		}
		if(!Bird.IsAlive)
		{
			anim.SetBool("IsAlive",false);
			gameObject.GetComponent<Rigidbody2D>().velocity =new Vector2(0,gameObject.GetComponent<Rigidbody2D>().velocity.y);
			gameObject.transform.rotation = new Quaternion(0,0, -1,1);
			return;
		}

		gameObject.transform.rotation = new Quaternion(0,0, gameObject.GetComponent<Rigidbody2D>().velocity.y/10,1);
		if(Input.GetMouseButtonDown(0)&& gameObject.transform.position.y < 3)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity =new Vector2(0,3f);
			GetComponent<AudioSource>().Play();
		}
	}

}
