using System;
using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService;
using PhotoAwards.Models;
using System.Collections.Generic;

namespace PhotoAwards.Helper
{
    public static class SMSHelper
    {
        public static bool SendSms(string PhoneNumber, string Message)
        {
            Console.WriteLine("Got Request from controller");

            AmazonSimpleNotificationServiceClient smsClient = new AmazonSimpleNotificationServiceClient("", "", Amazon.RegionEndpoint.APSouth1);
            var attributes = new Dictionary<string, MessageAttributeValue>();
            attributes.Add("AWS.SNS.SMS.SenderID", new MessageAttributeValue() { StringValue = "PhotoReward", DataType = "String" });
            attributes.Add("AWS.SNS.SMS.SMSType", new MessageAttributeValue() { StringValue = "Transactional", DataType = "String" });
            var request = new Amazon.SimpleNotificationService.Model.PublishRequest();
            request.PhoneNumber = PhoneNumber;
            request.Message = Message;
            request.MessageAttributes = attributes;
            var result = smsClient.PublishAsync(request).Result;
            Console.WriteLine(result.HttpStatusCode);
            Console.WriteLine(result.MessageId);
            return true;
        }
    }
}
