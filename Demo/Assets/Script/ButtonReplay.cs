using UnityEngine;
using System.Collections;

public class ButtonReplay : MonoBehaviour {

    /// <summary>
    /// Add this class to restart button.
    /// </summary>

	void OnMouseDown()
	{
		Bird.Points=0;
		Bird.IsAlive =true;
		Bird.IsStart=false;
		Input.ResetInputAxes();
		Application.LoadLevel(Application.loadedLevel);
	}
}
