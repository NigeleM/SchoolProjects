package com.example.weatherapp;

import android.app.Application;

import com.parse.Parse;
import com.parse.ParseObject;

public class ParseApplication extends Application {

    @Override
    public void onCreate() {
        super.onCreate();

        // Register your parse models
        ParseObject.registerSubclass(com.example.weatherapp.Post.class);
        Parse.initialize(new Parse.Configuration.Builder(this)
                .applicationId("2mS7Uz3dywWL8sb7AKt1dtSgR7zDGMn8iqNpRoqR")
                .clientKey("AWi8aH5VuYGNophtngXtkYR6MK7IN9ocZ024Nguz")
                .server("https://parseapi.back4app.com")
                .build()
        );
    }
}
