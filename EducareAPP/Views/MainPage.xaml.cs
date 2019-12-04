﻿using EducareAPP.Modles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EducareAPP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

     
        private void OnSignUpNowClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Oke");
                App.UserDatabase.SaveUser(user);
            }
            else 
            {

                DisplayAlert("Login", "Login Not Correct , empty username or password.", "Oke");
            
            
            
            }
        
        
        
        
        }
    }
} 
