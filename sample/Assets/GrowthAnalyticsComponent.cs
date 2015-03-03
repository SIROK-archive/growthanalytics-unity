using UnityEngine;
using System.Collections;

public class GrowthAnalyticsComponent : MonoBehaviour {

	void Awake () {
		GrowthAnalytics.GetInstance().Initialize("APPLICATION_ID","CREDENTIAL_ID");
	}

	void Start () {
	
	}

	void Update () {
	
	}
}
