using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log( "ログ" );
        Debug.LogError( "えらー", "エラーログ" );
        Debug.LogWarning( "わーにんぐ", "ワーニングログ" );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
