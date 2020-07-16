﻿using System;

namespace XamarinCommunityToolkitSample.Pages
{
    public partial class WelcomePage : BasePage
    {
        public WelcomePage()
            => InitializeComponent();

        async void OnAboutClicked(object sender, EventArgs e)
            => await Navigation.PushModalAsync(new BaseNavigationPage(new AboutPage()));
    }
}