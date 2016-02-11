using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

    /// <summary>
    /// Add this class to create a ground.
    /// </summary>

	Animator anim;

	void Start () {
		anim=gameObject.GetComponent<Animator>();
	}
	
	void Update () {
		if(!Bird.IsAlive)
		{
			anim.SetBool("IsAlive",false);
		}
	}
}
