using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GrowthAnalytics
{
	private static GrowthAnalytics instance = new GrowthAnalytics ();

	public static GrowthAnalytics GetInstance ()
	{
		return GrowthAnalytics.instance;
	}

	public enum Gender
	{
		GenderNone = 0,
		GenderMale = 1,
		GenderFemale = 2
	}

	public enum TrackOption
	{
		TrackOptionDefault = 0,
		TrackOptionOnce = 1,
		TrackOptionCounter = 2
	}

	public void Initialize (string applicationId, string credentialId)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.Initialize(applicationId, credentialId);
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.Initialize(applicationId, credentialId);
		#endif
	}

	public void Tag (string tagId)
	{
		Tag (tagId, null);
	}

	public void Tag (string tagId, string value)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.Tag(tagId, value);
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.Tag(tagId, value); 
		#endif
	}

	public void Track (string eventId)
	{
		Track (eventId, new Dictionary<string, string>(), 0);
	}

	public void Track (string eventId, Dictionary<string, string> properties)
	{
		Track (eventId, properties, 0);
	}
	
	public void Track (string eventId, TrackOption option)
	{
		Track (eventId, new Dictionary<string, string>(), option);
	}
	
	public void Track (string eventId, Dictionary<string, string> properties, TrackOption option)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.Track(eventId, properties, option);
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.Track(eventId, properties, (int)option);
		#endif
	}

	public void Open ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.Open();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.Open(); 
		#endif
	}
	
	public void Close ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.Close();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.Close(); 
		#endif
	}
	
	public void Purchase (int price, string category, string product)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.Purchase(price, category, product);
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.Purchase(price, category, product); 
		#endif
	}
	
	public void SetUserId (string userId)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetUserId(userId);
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetUserId(userId); 
		#endif
	}
	
	public void SetName (string name)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetName(name);
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetName(name); 
		#endif
	}
	
	public void SetAge (int age)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetAge(age);
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetAge(age); 
		#endif
	}
	
	public void SetGender(Gender gender) {
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetGender(gender); 
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetGender((int)gender); 
		#endif
	}
	
	public void SetLevel (int level)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetLevel(level);
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetLevel(level); 
		#endif
	}
	
	public void SetDevelopment (bool development) {
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetDevelopment(development);
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetDevelopment(development); 
		#endif
	}

	public void SetDeviceModel ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetDeviceModel();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetDeviceModel(); 
		#endif
	}
	
	public void SetOS ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetOS();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetOS(); 
		#endif
	}
	
	public void SetLanguage ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetLanguage();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetLanguage(); 
		#endif
	}
	
	public void SetTimeZone ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetTimeZone();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetTimeZone(); 
		#endif
	}
	
	public void SetTimeZoneOffset ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetTimeZoneOffset();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetTimeZoneOffset(); 
		#endif
	}
	
	public void SetAppVersion ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetAppVersion();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetAppVersion(); 
		#endif
	}
	
	public void SetRandom ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetRandom();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetRandom(); 
		#endif
	}
	
	public void SetAdvertisingId (string idfa)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetAdvertisingId();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetAdvertisingId(idfa); 
		#endif
	}
	
	public void SetBasicTags ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.SetBasicTags();
		#elif UNITY_IPHONE
		GrowthAnalyticsIOS.SetBasicTags(); 
		#endif
	}

}
