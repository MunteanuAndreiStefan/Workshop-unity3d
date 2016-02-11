using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    /// <summary>
    /// Add this clas to a GUIText to show the score. 
    /// </summary>

	GUIText txt;
	void Start () {
		txt=gameObject.GetComponent<GUIText>();
	}
	
	void Update () {
		if(!Bird.IsStart)
			return;
		txt.text =Bird.Points.ToString();
	}
}
