Growth Analytics SDK for Unity
===================

![Growth Analytics](https://analytics.growthbeat.com/) is the easiest way to implement analyzes for smart devices.

Growthbeat-core github page : https://github.com/SIROK/growthbeat-core-unity

```bash
git clone https://github.com/SIROK/growthanalytics-unity.git
cd ./growthanalytics-unity/ ; git submodule update --init --recursive
```

## Build sample project

### iOS

1. Copy GrowthAnalytics.framework and GrowthbeatCore.framework to /path/to/your_project/proj.ios/Frameworks/
1. From the Growthanalytics.framework > Headers > GrowthAnalytics.h, edit the GrowthbeatCore defined.
```c#
#import "GrowthbeatCore.h" to
#import "GrowthbeatCore/GrowthbeatCore.h"
```

### Android

1. Copy following jar files to /path/to/your_project/proj.android/libs/
  - growthbeat-core.jar
  - growthanalytics.jar
1. Add following below if AndroidManifest.xml existing.
```xml
...
<uses-permission android:name="android.permission.INTERNET" />
...
```

## Install

[1] Download the SDK

[2] Import Growthanalytics.unitypackage to the project.

[3] Define the variables GrowthAnalytics uses.

```bash
var applicationId : string = "APPLICATION_ID";
var credentialId : string = "CREDENTIAL_ID";
```

[4] Add the following to Awake

```bash
...
void Awake () {
	GrowthAnalytics.GetInstance().Initialize("applicationId", "credentialId");
	GrowthAnalytics.GetInstance().SetBasicTags();
	...
}
...
```

[5] Add the following under void Start()
```bash
GrowthAnalytics.GetInstance().open();
```

[6] If any places where the billing occurs, please add the following.

(CATEGORY: item、 gacha、 continue or custom strings)
```bash
GrowthAnalytics.GetInstance().purchase(PRICE, "CATEGORY", "PRODUCT");
```

[7] Please set in a possible acquisition range user information.
```bash
GrowthAnalytics.GetInstance().setUserId("USER_ID");
GrowthAnalytics.GetInstance().setAge(AGE);
GrowthAnalytics.GetInstance().setGender(GENDER);
GrowthAnalytics.GetInstance().setLevel(LEVEL);
```
