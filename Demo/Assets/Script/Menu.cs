using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
    /// <summary>
    /// Add this to a GameObject to create a SplashScreen style effect.
    /// </summary>

	void Update () {
		gameObject.transform.GetComponent<Renderer>().enabled=!Bird.IsStart;
	}
}
