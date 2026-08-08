NotificationService notificationService = new NotificationService();

notificationService.SendNotification(NotificationType.Email, "Account Created");
notificationService.SendNotification(NotificationType.SMS, "Loan Approved");
notificationService.SendNotification(NotificationType.Push, "Money Transferred");