package com.example.weatherapp;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.util.Log;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;

import com.example.weatherapp.Fragments.ComposeFragment;
import com.example.weatherapp.Fragments.Home;
import com.example.weatherapp.Fragments.PostsFragment;
import com.example.weatherapp.Fragments.ProfileFragment;
import com.example.weatherapp.Fragments.Week;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.parse.ParseUser;

import static com.example.weatherapp.R.id.action_profile;

public class MainActivity extends AppCompatActivity {

    public static final String TAG = "MainActivity";
    final FragmentManager fragmentManager = getSupportFragmentManager();
    public BottomNavigationView bottomNavigationView;
    EditText zip;
    String zipcode="";
    Button updateButton;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        zip = findViewById(R.id.zip);

        updateButton = findViewById(R.id.updateButton);

        updateButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {


                zipcode = zip.getText().toString();
                if (zipcode.length() != 5)
                    zipcode = "";

                Log.i("ZIPCODE", "ZIPCODE" + zipcode);
                bottomNavigationView.setSelectedItemId(R.id.action_home);
            }
        });


        bottomNavigationView = findViewById(R.id.bottom_navigation);

        bottomNavigationView.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @SuppressLint("NonConstantResourceId")
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {
                Fragment fragment = null;
                switch (menuItem.getItemId()) {
                    case R.id.action_home:
                        if(zipcode.isEmpty())
                            fragment = new Home();
                        else
                            fragment = new Home(zipcode);
                        break;
                    case R.id.action_week:
                        if(zipcode.isEmpty())
                            fragment = new Week();
                        else
                            fragment = new Week(zipcode);
                        break;
                    case R.id.action_compose:
                        fragment = new ComposeFragment();
                        break;
                    case action_profile:
                        fragment = new ProfileFragment();
                        break;
                    case R.id.action_posts:
                        fragment = new PostsFragment();
                        break;
                    default:
                        fragment = new Home();
                        break;



                }
                fragmentManager.beginTransaction().replace(R.id.flContainer, fragment).commit();
                return true;
            }
        });
        // Set default selection
        //bottomNavigationView.setSelectedItemId(R.id.action_home);
    }




}
