NotificationService notificationService = new NotificationService();

notificationService.SendNotification("email", "Account Created");
notificationService.SendNotification("sms", "Loan Approved");
notificationService.SendNotification("push", "Money Transferred");