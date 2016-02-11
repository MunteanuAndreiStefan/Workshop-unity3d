using UnityEngine;
using System.Collections;

public class MenuEnd : MonoBehaviour {

    /// <summary>
    /// Add this class to end game menu.
    /// </summary>

	bool IsActive =false;

	void Update () {
		if(!IsActive && ! Bird.IsAlive)
		{
			gameObject.transform.GetChild(0).gameObject.SetActive(true);
			gameObject.transform.GetChild(1).gameObject.SetActive(true);
		}
	}
}
