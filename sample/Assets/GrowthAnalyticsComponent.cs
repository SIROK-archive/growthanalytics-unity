using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GrowthAnalyticsComponent : MonoBehaviour {

	void Awake () {
//		GrowthAnalytics.GetInstance().Initialize("APPLICATION_ID","CREDENTIAL_ID");
		GrowthAnalytics.GetInstance().Initialize("OyTg8vZd4KTNQDJ5", "3EKydeJ0imxJ5WqS22FJfdVamFLgu7XA");

//		GrowthAnalytics.GetInstance().Track("EVENT_ID");
//		GrowthAnalytics.GetInstance().Track("EVENT_ID", GrowthAnalytics.GATrackOption.GATrackOptionOnce);
//
//		Dictionary<string, string> a = new Dictionary<string, string>
//		{
//			{"ant", "aunt"},
//			{"Sam", "Samantha"},
//			{"clozapine", "quetiapine"},
//			{"flomax", "volmax"},
//			{"toradol", "tramadol"}
//		};
//
//		GrowthAnalytics.GetInstance().Track("EVENT_ID", a);
//		GrowthAnalytics.GetInstance().Track("EVENT_ID", a, GrowthAnalytics.GATrackOption.GATrackOptionOnce);
		
		GrowthAnalytics.GetInstance().Tag("TAG_ID");
		GrowthAnalytics.GetInstance().Tag("TAG_ID", "VALUE");
		
		GrowthAnalytics.GetInstance().Open();
		GrowthAnalytics.GetInstance().Close();
		GrowthAnalytics.GetInstance().Purchase(3000, "CATEGORY", "PRODUCT");
		
		GrowthAnalytics.GetInstance().SetUserId("USER_ID");
		GrowthAnalytics.GetInstance().SetName("USER_NAME");
		GrowthAnalytics.GetInstance().SetAge(20);
//		GrowthAnalytics.GetInstance().SetGender(GrowthAnalytics.GAGender.GAGenderMale);
		GrowthAnalytics.GetInstance().SetLevel(99);
		GrowthAnalytics.GetInstance().SetDevelopment(false);
		GrowthAnalytics.GetInstance().SetDeviceModel();
		GrowthAnalytics.GetInstance().SetOS();
		GrowthAnalytics.GetInstance().SetLanguage();
		GrowthAnalytics.GetInstance().SetTimeZone();
		GrowthAnalytics.GetInstance().SetTimeZoneOffset();
		GrowthAnalytics.GetInstance().SetAppVersion();
		GrowthAnalytics.GetInstance().SetRandom();
		GrowthAnalytics.GetInstance().SetAdvertisingId("IDFA");
		GrowthAnalytics.GetInstance().SetBasicTags();

	}

	void Start () {
	
	}

	void Update () {
	
	}
}
