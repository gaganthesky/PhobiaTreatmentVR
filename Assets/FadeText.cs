using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeText : MonoBehaviour {
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		StartCoroutine(TextFade());
	}
	
	// Update is called once per frame
	IEnumerator TextFade () {
		yield return new WaitForSeconds(5);
		text.CrossFadeAlpha(0.0f, 1f, false);
	}
}
