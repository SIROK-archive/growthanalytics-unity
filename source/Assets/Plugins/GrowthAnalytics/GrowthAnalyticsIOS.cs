﻿using UnityEngine;
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GrowthAnalyticsIOS {

	#if UNITY_IPHONE
	[DllImport("__Internal")] static extern void initializeWithApplicationId(string applicationID, string credentialId);
	[DllImport("__Internal")] static extern void track(string eventId, string properties, int option);
	[DllImport("__Internal")] static extern void tag(string tagId, string value); 
	[DllImport("__Internal")] static extern void _open();
	[DllImport("__Internal")] static extern void _close();
	[DllImport("__Internal")] static extern void purchase(int price, string category, string product);
	[DllImport("__Internal")] static extern void setUserId(string userId);
	[DllImport("__Internal")] static extern void setName(string name);
	[DllImport("__Internal")] static extern void setAge(int age);
	[DllImport("__Internal")] static extern void setGender(int gender);
	[DllImport("__Internal")] static extern void setLevel(int level);
	[DllImport("__Internal")] static extern void setDevelopment(bool development);
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

	public static void Initialize (string applicationId, string credentialId)
	{
		#if UNITY_IPHONE
		initializeWithApplicationId(applicationId, credentialId);
		#endif
	}
	
	public static void Tag (string tagId, string value)
	{
		#if UNITY_IPHONE
		tag(tagId, value); 
		#endif
	}
	
	public static void Track (string eventId, Dictionary<string, string> properties, int option)
	{
		#if UNITY_IPHONE
		track(eventId, GetLine(properties), option);
		#endif
	}

	public static string GetLine(Dictionary<string, string> dictionary)
	{
		StringBuilder builder = new StringBuilder();
		foreach (KeyValuePair<string, string> pair in dictionary)
		{
			builder.Append("{").Append(pair.Key).Append(":").Append(pair.Value).Append("},");
		}
		string result = builder.ToString();
		result = result.TrimEnd(',');
		return result;
	}
	
	public static void Open ()
	{
		#if UNITY_IPHONE
		_open(); 
		#endif
	}
	
	public static void Close ()
	{
		#if UNITY_IPHONE
		_close(); 
		#endif
	}
	
	public static void Purchase (int price, string category, string product)
	{
		#if UNITY_IPHONE
		purchase(price, category, product); 
		#endif
	}
	
	public static void SetUserId (string userId)
	{
		#if UNITY_IPHONE
		setUserId(userId); 
		#endif
	}
	
	public static void SetName (string name)
	{
		#if UNITY_IPHONE
		setName(name); 
		#endif
	}
	
	public static void SetAge (int age)
	{
		#if UNITY_IPHONE
		setAge(age); 
		#endif
	}
	
	public static void SetGender(int gender) {
		#if UNITY_IPHONE
		setGender(gender); 
		#endif
	}
	
	public static void SetLevel (int level)
	{
		#if UNITY_IPHONE
		setLevel(level); 
		#endif
	}
	
	public static void SetDevelopment (bool development) {
		#if UNITY_IPHONE
		setDevelopment(development); 
		#endif
	}
	
	public static void SetDeviceModel ()
	{
		#if UNITY_IPHONE
		setDeviceModel(); 
		#endif
	}
	
	public static void SetOS ()
	{
		#if UNITY_IPHONE
		setOS(); 
		#endif
	}
	
	public static void SetLanguage ()
	{
		#if UNITY_IPHONE
		setLanguage(); 
		#endif
	}
	
	public static void SetTimeZone ()
	{
		#if UNITY_IPHONE
		setTimeZone(); 
		#endif
	}
	
	public static void SetTimeZoneOffset ()
	{
		#if UNITY_IPHONE
		setTimeZoneOffset(); 
		#endif
	}
	
	public static void SetAppVersion ()
	{
		#if UNITY_IPHONE
		setAppVersion(); 
		#endif
	}
	
	public static void SetRandom ()
	{
		#if UNITY_IPHONE
		setRandom(); 
		#endif
	}
	
	public static void SetAdvertisingId (string idfa)
	{
		#if UNITY_IPHONE
		setAdvertisingId(idfa); 
		#endif
	}
	
	public static void SetBasicTags ()
	{
		#if UNITY_IPHONE
		setBasicTags(); 
		#endif
	}
	
};