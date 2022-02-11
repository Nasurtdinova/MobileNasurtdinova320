﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace TestNasurtdinova320
{
    public partial class MainPage : ContentPage
    {
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            imgList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
            UpdateList();
        }

        void UpdateList()
        {
            imgList.ItemsSource = Directory.GetFiles(folderPath).Select(f => Path.GetFullPath(f));
            imgList.SelectedItem = 0;
        }

        async void GetPhotoAsync(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                //img.Source = ImageSource.FromFile(photo.FullPath);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

        async void TakePhotoAsync(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
                {
                    Title = $"xamarin.{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.png"
                });

                var newFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), photo.FileName);
                using (var stream = await photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(newFile))
                    await stream.CopyToAsync(newStream);

                Debug.WriteLine($"Путь фото {photo.FullPath}");
                //img.Source = ImageSource.FromFile(photo.FullPath);
                UpdateList();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

        private async void imgList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Image selectedImage = (Image)e.SelectedItem;
            SelectedImagePage imagePage = new SelectedImagePage();
            imagePage.BindingContext = selectedImage;
            await Navigation.PushAsync(imagePage);
        }
    }
}
