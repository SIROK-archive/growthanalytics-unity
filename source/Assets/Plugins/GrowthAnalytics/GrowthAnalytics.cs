using System.Collections;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

public class GrowthAnalytics
{
	private static GrowthAnalytics instance = new GrowthAnalytics ();

	#if UNITY_IPHONE && !UNITY_EDITOR
	[DllImport("__Internal")] static extern void initializeWithApplicationId(string applicationID, string credentialId);
	[DllImport("__Internal")] static extern void track(string eventId);
	/*
	 * [DllImport("__Internal")] static extern void track(string applicationID, string credentialId);
	 * [DllImport("__Internal")] static extern void track(string applicationID, string credentialId);
	 * [DllImport("__Internal")] static extern void track(string applicationID, string credentialId);
	 */
	[DllImport("__Internal")] static extern void tag(string tagId, string value); 
	[DllImport("__Internal")] static extern void _open();
	[DllImport("__Internal")] static extern void _close();
	[DllImport("__Internal")] static extern void purchase(int price, string category, string product);
	[DllImport("__Internal")] static extern void setUserId(string userId);
	[DllImport("__Internal")] static extern void setName(string name);
	[DllImport("__Internal")] static extern void setAge(int age);
	//	[DllImport("__Internal")] static extern void setGender();
	[DllImport("__Internal")] static extern void setLevel(int level);
	//	[DllImport("__Internal")] static extern void setDevelopment();
	[DllImport("__Internal")] static extern void setDeviceModel();
	[DllImport("__Internal")] static extern void setOS();
	[DllImport("__Internal")] static extern void setLanguage();
	[DllImport("__Internal")] static extern void setTimeZone();
	[DllImport("__Internal")] static extern void setTimeZoneOffset();
	[DllImport("__Internal")] static extern void setAppVersion();
	[DllImport("__Internal")] static extern void setRandom();
	[DllImport("__Internal")] static extern void setAdvertisingId(string idfa);
	[DllImport("__Internal")] static extern void setBasicTags();
	#endif

	public static GrowthAnalytics GetInstance ()
	{
		return GrowthAnalytics.instance;
	}

	public void Initialize (string applicationId, string credentialId)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.Initialize(applicationId, credentialId);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		initializeWithApplicationId(applicationId, credentialId);
		#endif
	}

	public void Tag (string tagId)
	{
		Tag(tagId, null);
	}
	
	public void Tag (string tagId, string value)
	{
		#if UNITY_ANDROID
			GrowthAnalyticsAndroid.tag(tagId, value);
		#elif UNITY_IPHONE && !UNITY_EDITOR
			tag(tagId, value); 
		#endif
	}

	public void Track (string eventId)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.track(eventId);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		track(eventId);
		#endif
	}

	/*public void Track(string eventId) {
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.track(eventId);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		GrowthAnalyticsIOS.track(eventId); 
		#endif
	}

	public void Track(string eventId) {
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.track(eventId);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		GrowthAnalyticsIOS.track(eventId); 
		#endif
	}

	public void Track(string eventId) {
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.track(eventId);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		GrowthAnalyticsIOS.track(eventId); 
		#endif
	}*/



	public void Open ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.open();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		_open(); 
		#endif
	}
	
	public void Close ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.close();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		_close(); 
		#endif
	}
	
	public void Purchase (int price, string category, string product)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.purchase(price, category, product);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		purchase(price, category, product); 
		#endif
	}
	
	public void SetUserId (string userId)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setUserId(userId);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setUserId(userId); 
		#endif
	}
	
	public void SetName (string name)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setName(name);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setName(name); 
		#endif
	}
	
	public void SetAge (int age)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setAge(age);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setAge(age); 
		#endif
	}

	/*
	public void SetGender() {
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.open();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		open(); 
		#endif
	}*/
	
	public void SetLevel (int level)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setLevel(level);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setLevel(level); 
		#endif
	}

	/*
	public void SetDevelopment() {
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.open();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		open(); 
		#endif
	}*/

	public void SetDeviceModel ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setDeviceModel();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setDeviceModel(); 
		#endif
	}
	
	public void SetOS ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setOS();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setOS(); 
		#endif
	}
	
	public void SetLanguage ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setLanguage();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setLanguage(); 
		#endif
	}
	
	public void SetTimeZone ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setTimeZone();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setTimeZone(); 
		#endif
	}
	
	public void SetTimeZoneOffset ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setTimeZoneOffset();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setTimeZoneOffset(); 
		#endif
	}
	
	public void SetAppVersion ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setAppVersion();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setAppVersion(); 
		#endif
	}
	
	public void SetRandom ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setRandom();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setRandom(); 
		#endif
	}
	
	public void SetAdvertisingId (string idfa)
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setAdvertisingId(idfa);
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setAdvertisingId(idfa); 
		#endif
	}
	
	public void SetBasicTags ()
	{
		#if UNITY_ANDROID
		GrowthAnalyticsAndroid.setBasicTags();
		#elif UNITY_IPHONE && !UNITY_EDITOR
		setBasicTags(); 
		#endif
	}

}
