using UnityEngine;
using System.Collections;
using System;

public class GrowthAnalyticsAndroid {

		private static GrowthAnalyticsAndroid instance = new GrowthAnalyticsAndroid();

		#if UNITY_ANDROID && !UNITY_EDITOR
			private static AndroidJavaObject growthAnalytics;
		#endif

		private GrowthAnalyticsAndroid() {
				#if UNITY_ANDROID && !UNITY_EDITOR
				using(AndroidJavaClass gbcclass = new AndroidJavaClass( "com.growthAnalytics.GrowthAnalytics" )) {
					growthAnalytics = gbcclass.CallStatic<AndroidJavaObject>("getInstance"); 
					}
				#endif
		}

		public static void Initialize(string applicationId, string credentialId) {
			instance.PrivateInitialize(applicationId, credentialId);
		}

		private void PrivateInitialize(string applicationId, string credentialId) {
				#if UNITY_ANDROID && !UNITY_EDITOR
				if (growthAnalytics == null)
						return;
					AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"); 
					AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"); 
					growthAnalytics.Call<AndroidJavaObject>("initialize", activity, applicationId, credentialId);
				#endif
		}

}
