using System.Collections;
using System.Collections.Generic;
using System;
using Unity.Notifications.Android;
using UnityEngine;

public class AndroidNotif : MonoBehaviour
{
	private const string ChannelId = "notification_channel";

	private void ScheduleNotification(DateTime dateTime)
	{
		AndroidNotificationChannel notificationChannel = new AndroidNotificationChannel
		{
			Id = ChannelId,
			Name = "Notification Channel",
			Description = "Some random description",
			Importance = Importance.Default
		};

		AndroidNotificationCenter.RegisterNotificationChannel(notificationChannel);

		AndroidNotification notification = new AndroidNotification
		{
			Title = "Energy Recharged!",
			Text = "Your energy has recharged, come back to play again!",
			SmallIcon = "default",
			LargeIcon = "default",
			FireTime = dateTime
		};
		AndroidNotificationCenter.SendNotification(notification, ChannelId);
	}
}
