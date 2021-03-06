﻿using Android.Content;
using Android.OS;
using Xamarin.Forms;

namespace XamarinFormBGdemo.Droid
{
    [BroadcastReceiver]
    public class BackgroundReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            PowerManager pm = (PowerManager)context.GetSystemService(Context.PowerService);
            PowerManager.WakeLock wakeLock = pm.NewWakeLock(WakeLockFlags.Partial, nameof(BackgroundReceiver));
            wakeLock.Acquire();

            MessagingCenter.Send<object, string>(this, "UpdateLabel", "Modify from Android BroadcastReceiver");

            wakeLock.Release();
        }
    }
}
