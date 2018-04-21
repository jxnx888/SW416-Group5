﻿using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace FitnessApp
{
    public partial class MapPage : ContentPage
    {
        Map map;
        Timer timer;
        int mins = 0, secs = 0, milliseconds = 1;

        public MapPage()
        {
            InitializeComponent();


            var map = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(41.158853, -73.257352), Distance.FromMiles(0.3)))//location of Fairfield University
            {
                IsShowingUser = true,
                HeightRequest = 250,
                VerticalOptions = LayoutOptions.Center
            };
            map.MapType = MapType.Street;



            //Add Stopwatch


            Label lblTimer = new Label
            {
                IsVisible = true,
                Text = "00:00:000",
                FontSize = 50,
                HorizontalOptions = LayoutOptions.Center
            };


            Button btnStart = new Button
            {
                IsVisible = true,
                Text = "Start",
                FontSize=25,
                TextColor = Color.White,
                BackgroundColor = Color.DeepSkyBlue,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 100,
                HeightRequest = 100,
                BorderRadius = 50

            };

            Button btnStop = new Button
            {
                IsVisible = true,
                Text = "Stop",
                FontSize = 25,
                TextColor = Color.White,
                BackgroundColor = Color.DeepSkyBlue,
                WidthRequest = 100,
                HeightRequest = 100,
                BorderRadius = 50
            };

            Button btnPause = new Button
            {
                IsVisible = true,
                Text = "Pause",
                FontSize = 25,
                TextColor = Color.White,
                BackgroundColor = Color.DeepSkyBlue,
                WidthRequest = 100,
                HeightRequest=100,
                BorderRadius=50
                
            };

            var stackMap = new StackLayout
            {
                Spacing = 0,
                Children =
                {
                    map,
                    lblTimer,

                    new StackLayout
                    {
                        Spacing = 0,
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Center,
                        Padding= new Thickness(20, 10, 20, 10),
                        Children =
                        {
                            btnStart,
                            btnStop,
                            btnPause
                        }
                   }
                   }
      
        };
            
            Content = stackMap;

         }
    

    }
}