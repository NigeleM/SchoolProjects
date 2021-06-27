package com.example.weatherapp.Fragments;

import android.graphics.Typeface;
import android.os.Bundle;
import android.os.StrictMode;
import android.text.Html;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.core.app.ActivityCompat;
import androidx.fragment.app.Fragment;

import com.example.weatherapp.R;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

import static android.Manifest.permission.ACCESS_FINE_LOCATION;

public class Week extends Fragment {

    public static final String OPEN_WEATHER_MAP_API = "d5ba82c221f1aa63bf314550a0f8168d";
    public static final String OPEN_WEATHER_MAP_URL ="https://api.openweathermap.org/data/2.5/forecast?zip=%s,US&exclude=hourly,daily&units=imperial&appid=d5ba82c221f1aa63bf314550a0f8168d";


    String zipcode;
    TextView  detailsField, currentTemperatureField, humidityField, pressureField, weatherIcon, updateField;
    TextView  detailsField1, currentTemperatureField1, humidityField1, pressureField1, weatherIcon1, updateField1;
    TextView  detailsField2, currentTemperatureField2, humidityField2, pressureField2, weatherIcon2, updateField2;
    TextView  detailsField3, currentTemperatureField3, humidityField3, pressureField3, weatherIcon3, updateField3;
    TextView  detailsField4, currentTemperatureField4, humidityField4, pressureField4, weatherIcon4, updateField4;
    Typeface weatherFont;
    static String latitude;
    static String longitude;

    public Week() {
        // Required empty public constructor
    }

    public Week(String zip) {
        // Required empty public constructor
        zipcode = zip;
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.activity_week, container, false);

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

                    currentTemperatureField = view.findViewById(R.id.current_temperature_field);
                    updateField = view.findViewById(R.id.updated_field);
                    detailsField = view.findViewById(R.id.details_field);
                    humidityField = view.findViewById(R.id.humidity_field);
                    pressureField = view.findViewById(R.id.pressure_field);
                    weatherIcon =view.findViewById(R.id.weather_icon);
                    weatherIcon.setTypeface(weatherFont);

                    currentTemperatureField1 = view.findViewById(R.id.current_temperature_field1);
                    updateField1 = view.findViewById(R.id.updated_field1);
                    detailsField1 = view.findViewById(R.id.details_field1);
                    humidityField1 = view.findViewById(R.id.humidity_field1);
                    pressureField1 = view.findViewById(R.id.pressure_field1);
                    weatherIcon1 =view. findViewById(R.id.weather_icon1);
                    weatherIcon1.setTypeface(weatherFont);

                    currentTemperatureField2 = view.findViewById(R.id.current_temperature_field2);
                    updateField2 = view.findViewById(R.id.updated_field2);
                    detailsField2 = view.findViewById(R.id.details_field2);
                    humidityField2 = view.findViewById(R.id.humidity_field2);
                    pressureField2 = view.findViewById(R.id.pressure_field2);
                    weatherIcon2 =view. findViewById(R.id.weather_icon2);
                    weatherIcon2.setTypeface(weatherFont);

                    currentTemperatureField3 = view.findViewById(R.id.current_temperature_field3);
                    updateField3 = view.findViewById(R.id.updated_field3);
                    detailsField3 = view.findViewById(R.id.details_field3);
                    humidityField3 = view.findViewById(R.id.humidity_field3);
                    pressureField3 = view.findViewById(R.id.pressure_field3);
                    weatherIcon3 =view. findViewById(R.id.weather_icon3);
                    weatherIcon3.setTypeface(weatherFont);

                    currentTemperatureField4 = view.findViewById(R.id.current_temperature_field4);
                    updateField4 = view.findViewById(R.id.updated_field4);
                    detailsField4 = view.findViewById(R.id.details_field4);
                    humidityField4 = view.findViewById(R.id.humidity_field4);
                    pressureField4 = view.findViewById(R.id.pressure_field4);
                    weatherIcon4 =view. findViewById(R.id.weather_icon4);
                    weatherIcon4.setTypeface(weatherFont);


                    String[][] jsonData = getJSONResponse();
                    detailsField.setText(jsonData[0][1]);
                    currentTemperatureField.setText(jsonData[0][2]);
                    humidityField.setText("Humidity : " + jsonData[0][3]);
                    pressureField.setText("Pressure : " + jsonData[0][4]);
                    updateField.setText(jsonData[0][5]);
                    weatherIcon.setText(Html.fromHtml(jsonData[0][6], i));

                    detailsField1.setText(jsonData[1][1]);
                    currentTemperatureField1.setText(jsonData[1][2]);
                    humidityField1.setText("Humidity : " + jsonData[1][3]);
                    pressureField1.setText("Pressure : " + jsonData[1][4]);
                    updateField1.setText(jsonData[1][5]);
                    weatherIcon1.setText(Html.fromHtml(jsonData[1][6], i));

                    detailsField2.setText(jsonData[2][1]);
                    currentTemperatureField2.setText(jsonData[2][2]);
                    humidityField2.setText("Humidity : " + jsonData[2][3]);
                    pressureField2.setText("Pressure : " + jsonData[2][4]);
                    updateField2.setText(jsonData[2][5]);
                    weatherIcon2.setText(Html.fromHtml(jsonData[2][6], i));

                    detailsField3.setText(jsonData[3][1]);
                    currentTemperatureField3.setText(jsonData[3][2]);
                    humidityField3.setText("Humidity : " + jsonData[3][3]);
                    pressureField3.setText("Pressure : " + jsonData[3][4]);
                    updateField3.setText(jsonData[3][5]);
                    weatherIcon3.setText(Html.fromHtml(jsonData[3][6], i));

                    detailsField4.setText(jsonData[4][1]);
                    currentTemperatureField4.setText(jsonData[4][2]);
                    humidityField4.setText("Humidity : " + jsonData[4][3]);
                    pressureField4.setText("Pressure : " + jsonData[4][4]);
                    updateField4.setText(jsonData[4][5]);
                    weatherIcon4.setText(Html.fromHtml(jsonData[4][6], i));



                   Log.i("JSON ARRAY", "DATA" + jsonData.toString());
                }





    public String[][] getJSONResponse() {
        String[][] jsonData = new String[7][7];
        JSONObject jsonWeather = null;
        try {
            if (zipcode == null)
                zipcode = "35814";
            jsonWeather = getWeatherJSON(zipcode);
        } catch (Exception e) {
            Log.d("Error ", "Cannot process JSON Request");

        }

        try {
            if (jsonWeather != null) {

                System.out.println("JSON WEATHER := "+jsonWeather);
                JSONObject Day1 = jsonWeather.getJSONObject("list 0");
                Log.i("Week JSON DAY1", "DAY1 " + Day1);
                JSONObject Day2 = jsonWeather.getJSONObject("list 8");
                Log.i("Week JSON DAY2", "DAY2 " + Day2);
                JSONObject Day3 = jsonWeather.getJSONObject("list 16");
                Log.i("Week JSON DAY3", "DAY3 " + Day3);
                JSONObject Day4 = jsonWeather.getJSONObject("list 24");
                Log.i("Week JSON DAY4", "DAY4 " + Day4);
                JSONObject Day5 = jsonWeather.getJSONObject("list 32");
                Log.i("Week JSON DAY5", "DAY5 " + Day5);
                JSONObject City = jsonWeather.getJSONObject("city");
                Log.i("Week JSON CITY", "CITY " + City);

                JSONObject Week = new JSONObject();

                Week.put("Day1",Day1);
                Week.put("Day2",Day2);
                Week.put("Day3",Day3);
                Week.put("Day4",Day4);
                Week.put("Day5",Day5);

                String [] Days = { "Day1", "Day2","Day3","Day4","Day5"};


                for(int count = 0; count <= Week.length(); count++) {

                    JSONObject Day = Week.getJSONObject(Days[count]);
                    JSONObject details = Day.getJSONArray("weather").getJSONObject(0);
                    JSONObject main = Day.getJSONObject("main");
                    System.out.println(Days[count]);


                    String city = City.getString("name") + ", " + City.getString("country");
                    Log.i("Week JSON CITY", "CITY " + city);
                    String description = details.getString("description").toLowerCase(Locale.US);
                    Log.i("Week JSON DESC", "DESC " + description);
                    String temperature = String.format("%.0f", main.getDouble("temp")) + "°";
                    Log.i("Week JSON TEMP", "TEMP " + temperature);
                    String humidity = main.getString("humidity") + "%";
                    Log.i("Week JSON HUMI", "HUMI " + humidity);
                    String pressure = main.getString("pressure") + " hPa";
                    Log.i("Week JSON PRES", "PRES " + pressure);


                    SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
                    Date date = format.parse(Day.getString("dt_txt"));
                    String dates = date.toString();
                    String[] datess = dates.split(" ");
                    String updatedOn = datess[0] + "," + datess[1] + " " + datess[2];


                    Log.i("Week JSON UPDA", "UPDA " + updatedOn);
                    String iconText = setWeatherIcon(details.getInt("id"), City.getLong("sunrise") * 1000,
                            City.getLong("sunset") * 1000);
                    Log.i("Week JSON ICON", "ICON " + iconText);
                    Long sunrise = jsonWeather.getJSONObject("city").getLong("sunrise");
                    Long sunset = jsonWeather.getJSONObject("city").getLong("sunset");
                    Log.i("Week JSON SUNR", "SUNR " + sunrise.toString());
                    Log.i("Week JSON SUNS", "SUNS " + sunset.toString());


                    jsonData[count][0] = city;
                    jsonData[count][1] = description;
                    jsonData[count][2] = temperature;
                    jsonData[count][3] = humidity;
                    jsonData[count][4] = pressure;
                    jsonData[count][5] = updatedOn;
                    jsonData[count][6] = iconText;

                }




            }

        } catch (Exception e) {


        }
        return jsonData;
    }


    public static String setWeatherIcon(int actualId ,long sunrise, long sunset) {
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

    public static JSONObject getWeatherJSON( String zip) {


            // Download JSON.
            try {

                URL url = new URL(String.format(OPEN_WEATHER_MAP_URL, zip));
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

                //System.out.println("jsonObject = " + data);

                JSONArray list = data.getJSONArray("list");
                //System.out.println("list = " + list);
                JSONObject datum = new JSONObject();
                // Loop through each item
                datum.put("city",data.getJSONObject("city"));
                for (int count = 0;  count < list.length(); count++ ) {




                    if ( 0== (count % 8) )
                    {
                        datum.put("list "+ count,list.get(count));
                        System.out.println("list = " + list.get(count));
                    }


                }



                return datum;

            } catch (Exception e) {
                return null;

            }


        }


    private void requestPermissions() {
        ActivityCompat.requestPermissions(getActivity(), new String[]{ACCESS_FINE_LOCATION}, 1);
    }


}
