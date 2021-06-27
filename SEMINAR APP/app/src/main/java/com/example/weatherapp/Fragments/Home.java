package com.example.weatherapp.Fragments;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.fragment.app.Fragment;

import android.app.Activity;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Typeface;
import android.location.Location;
import android.os.Bundle;
import android.os.Parcelable;
import android.os.StrictMode;
import android.text.Editable;
import android.text.Html;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.example.weatherapp.MainActivity;
import com.example.weatherapp.R;
import com.google.android.gms.location.FusedLocationProviderClient;
import com.google.android.gms.location.LocationServices;
import com.google.android.gms.tasks.OnSuccessListener;
import com.parse.ParseUser;

import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.text.DateFormat;
import java.util.Date;
import java.util.Locale;
import java.util.concurrent.Executor;

import static android.Manifest.permission.ACCESS_FINE_LOCATION;
public class Home extends Fragment {


    public static final String OPEN_WEATHER_MAP_URL = "https://api.openweathermap.org/data/2.5/weather?&zip=%s,US&units=imperial&appid=d5ba82c221f1aa63bf314550a0f8168d";
    public static final String OPEN_WEATHER_MAP_API = "d5ba82c221f1aa63bf314550a0f8168d";


    String zipcode;
    TextView cityField, detailsField, currentTemperatureField, humidityField, pressureField, weatherIcon, updateField;
    Typeface weatherFont;
    Button SearchButton;
    static String latitude;
    static String longitude;


    public Home() {
        // Required empty public constructor
    }

    public Home(String zip) {
        zipcode = zip;
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        return inflater.inflate(R.layout.activity_home, container, false);
    }

    @Override
    public void onViewCreated(@NonNull final View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);

        final int i = 10;

        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);
        requestPermissions();


        Typeface typeface = getResources().getFont(R.font.weathericons_regular_webfont);
        weatherFont = typeface;

        cityField = view.findViewById(R.id.city_field);
        currentTemperatureField = view.findViewById(R.id.current_temperature_field);
        updateField = view.findViewById(R.id.updated_field);
        detailsField = view.findViewById(R.id.details_field);
        humidityField = view.findViewById(R.id.humidity_field);
        pressureField = view.findViewById(R.id.pressure_field);
        weatherIcon = view.findViewById(R.id.weather_icon);
        weatherIcon.setTypeface(weatherFont);

        String[] jsonData = getJSONResponse();
        cityField.setText(jsonData[0]);
        detailsField.setText(jsonData[1]);
        currentTemperatureField.setText(jsonData[2]);
        humidityField.setText("Humidity : " + jsonData[3]);
        pressureField.setText("Pressure : " + jsonData[4]);
        updateField.setText(jsonData[5]);
        weatherIcon.setText(Html.fromHtml(jsonData[6], i));

        Log.i("JSON READ", "DATA" + jsonData.toString());


        SearchButton = view.findViewById(R.id.SearchButton);

        SearchButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(getActivity(), MainActivity.class);
                startActivity(i);
                ((Activity) getActivity()).overridePendingTransition(0, 0);
            }
        });
    }






    public String[] getJSONResponse() {
        String[] jsonData = new String[7];
        JSONObject jsonWeather = null;
        try {
            if (zipcode == null)
                zipcode = "35814";
            jsonWeather = getWeatherJSON(latitude, longitude, zipcode);
        } catch (Exception e) {
            Log.d("Error ", "Cannot process JSON Request");

        }

        try {
            if (jsonWeather != null) {
                JSONObject details = jsonWeather.getJSONArray("weather").getJSONObject(0);
                Log.i("HOME JSON READ WEATHER", "DATA" + jsonWeather);
                Log.i("HOME JSON R1", "DATA1" + details);

                JSONObject main = jsonWeather.getJSONObject("main");
                Log.i("JSON R2", "DATA2" + main);
                DateFormat df = DateFormat.getDateInstance();

                String city = jsonWeather.getString("name") + ", " + jsonWeather.getJSONObject("sys").getString("country");
                String description = details.getString("description").toLowerCase(Locale.US);
                String temperature = String.format("%.0f", main.getDouble("temp")) + "°";
                String humidity = main.getString("humidity") + "%";
                String pressure = main.getString("pressure") + " hPa";
                String updatedOn = df.format(new Date(jsonWeather.getLong("dt") * 1000));
                String iconText = setWeatherIcon(details.getInt("id"), jsonWeather.getJSONObject("sys").getLong("sunrise") * 1000,
                        jsonWeather.getJSONObject("sys").getLong("sunset") * 1000);

                jsonData[0] = city;
                jsonData[1] = description;
                jsonData[2] = temperature;
                jsonData[3] = humidity;
                jsonData[4] = pressure;
                jsonData[5] = updatedOn;
                jsonData[6] = iconText;


            }

        } catch (Exception e) {


        }
        return jsonData;
    }


    public static String setWeatherIcon(int actualId, long sunrise, long sunset) {


        int id = actualId / 100;
        String icon = "";
        if (actualId == 800) {
            long currentTime = new Date().getTime();
            if (currentTime >= sunrise && currentTime < sunset) {
                icon = "&#xf00d;";
            } else {
                icon = "&#xf02e;";
            }
        } else {
            switch (id) {
                case 2:
                    icon = "&#xf01e;";
                    break;
                case 3:
                    icon = "&#xf01c;";
                    break;
                case 7:
                    icon = "&#xf014;";
                    break;
                case 8:
                    icon = "&#xf013;";
                    break;
                case 6:
                    icon = "&#xf01b;";
                    break;
                case 5:
                    icon = "&#xf019;";
                    break;
            }
        }
        return icon;
    }

    public static JSONObject getWeatherJSON(String lat, String lon, String zip) {
        try {
            URL url = new URL(String.format(OPEN_WEATHER_MAP_URL, zip));
            Log.i("JSON URL", "DATA" + url);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.addRequestProperty("x-api-key", OPEN_WEATHER_MAP_API);
            BufferedReader reader = new BufferedReader(new InputStreamReader(connection.getInputStream()));
            StringBuffer json = new StringBuffer(1024);
            String tmp = "";
            while ((tmp = reader.readLine()) != null) {
                json.append(tmp).append("\n");

            }
            reader.close();
            JSONObject data = new JSONObject(json.toString());
            if (data.getInt("cod") != 200) {
                return null;
            }
            return data;

        } catch (Exception e) {
            return null;

        }


    }

    private void requestPermissions() {
        ActivityCompat.requestPermissions(getActivity(), new String[]{ACCESS_FINE_LOCATION}, 1);
    }


}
