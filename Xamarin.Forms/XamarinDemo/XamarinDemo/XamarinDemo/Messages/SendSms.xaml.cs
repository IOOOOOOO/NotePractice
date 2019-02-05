﻿using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.Messages.Models;

namespace XamarinDemo.Messages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SendSms : ContentPage
	{
		public SendSms()
		{
			InitializeComponent ();
            BindingContext = new SendSmsViewModel()
            {
                PhoneNumber = "",
                Content=""
            };
        }

        public void SendSmsClicked(object sender, EventArgs e)
        {
            var data = BindingContext as SendSmsViewModel;
            //https://docs.microsoft.com/zh-cn/xamarin/essentials/sms
            //var message = new SmsMessage(data.Content, new[] { data.PhoneNumber });
            //Task.Run(async()=> { await Sms.ComposeAsync(message)});
        }
    }
}