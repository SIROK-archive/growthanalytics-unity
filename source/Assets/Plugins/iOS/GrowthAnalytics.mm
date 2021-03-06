//
//  GrowthPush.mm
//
//
//  Created by Cuong Do on 11/5/13.
//
//

#import <UIKit/UIKit.h>
#import <GrowthAnalytics/GrowthAnalytics.h>

NSString* NSStringFromCharString(const char* charString) {
	if(charString == NULL)
		return nil;
    return [NSString stringWithCString:charString encoding:NSUTF8StringEncoding];
}

extern "C" void initializeWithApplicationId(const char* applicationId, const char* credentialId) {
    [[GrowthAnalytics sharedInstance] initializeWithApplicationId:NSStringFromCharString(applicationId) credentialId:NSStringFromCharString(credentialId)];
}

extern "C" void track(const char* eventId) {
    [[GrowthAnalytics sharedInstance] track:NSStringFromCharString(eventId)];
}

/*
- (void)track:(NSString *)eventId properties:(NSDictionary *)properties;
extern "C" void track(const char* eventId, ) {
    [[GrowthAnalytics sharedInstance] track];
}*/

/*
- (void)track:(NSString *)eventId option:(GATrackOption)option;
extern "C" void track() {
    [[GrowthAnalytics sharedInstance] track];
}

- (void)track:(NSString *)eventId properties:(NSDictionary *)properties option:(GATrackOption)option;
extern "C" void track() {
    [[GrowthAnalytics sharedInstance] track];
}*/

extern "C" void tag(const char* tagId, const char* value) {
    [[GrowthAnalytics sharedInstance] tag:NSStringFromCharString(tagId) value:NSStringFromCharString(value)];
}

extern "C" void _open() {
    [[GrowthAnalytics sharedInstance] open];
}

extern "C" void _close() {
    [[GrowthAnalytics sharedInstance] close];
}

extern "C" void purchase(int price, const char* category, const char* product) {
    [[GrowthAnalytics sharedInstance] purchase:price setCategory:NSStringFromCharString(category) setProduct:NSStringFromCharString(product)];
}

extern "C" void setUserId(const char* userId) {
    [[GrowthAnalytics sharedInstance] setUserId:NSStringFromCharString(userId)];
}

extern "C" void setName(const char* name) {
    [[GrowthAnalytics sharedInstance] setName:NSStringFromCharString(name)];
}

extern "C" void setAge(int age) {
    [[GrowthAnalytics sharedInstance] setAge:age];
}

/*
- (void)setGender:(GAGender)gender;
extern "C" void setGender() {
    [[GrowthAnalytics sharedInstance] ];
}*/

extern "C" void setLevel(int level) {
    [[GrowthAnalytics sharedInstance] setLevel:level];
}

/*
- (void)setDevelopment:(BOOL)development;
extern "C" void setDevelopment() {
    [[GrowthAnalytics sharedInstance] ];
}*/

extern "C" void setDeviceModel() {
    [[GrowthAnalytics sharedInstance] setDeviceModel];
}

extern "C" void setOS() {
    [[GrowthAnalytics sharedInstance] setOS];
}

extern "C" void setLanguage() {
    [[GrowthAnalytics sharedInstance] setLanguage];
}

extern "C" void setTimeZone() {
    [[GrowthAnalytics sharedInstance] setTimeZone];
}

extern "C" void setTimeZoneOffset() {
    [[GrowthAnalytics sharedInstance] setTimeZoneOffset];
}

extern "C" void setAppVersion() {
    [[GrowthAnalytics sharedInstance] setAppVersion];
}

extern "C" void setRandom() {
    [[GrowthAnalytics sharedInstance] setRandom];
}

extern "C" void setAdvertisingId(const char* idfa) {
    [[GrowthAnalytics sharedInstance] setAdvertisingId:NSStringFromCharString(idfa)];
}

extern "C" void setBasicTags() {
    [[GrowthAnalytics sharedInstance] setBasicTags];
}

/*typedef NS_ENUM (NSInteger, GATrackOption) {
    GATrackOptionDefault = 0,
    GATrackOptionOnce,
    GATrackOptionCounter
};

typedef NS_ENUM (NSInteger, GAGender) {
    GAGenderNone = 0,
    GAGenderMale,
    GAGenderFemale
};*/