﻿namespace Pushenger.Core.Utilities
{
    public static class Constant
    {
        public static string DefaultTopicName = "First Topic";
        #region Localization        
        public static string Successful => "Successful";
        public static string Error => "Error";
        public static string TokenNotFound => "TokenNotFound";
        public static string LogOuted => "LogOuted";
        public static string UnAuthorized => "UnAuthorized";        

        public static class CompanyMessages
        {
            public static string CompanyAlreadyExists => "CompanyAlreadyExists";
            public static string UserAlreadyExists => "UserAlreadyExists";
            public static string CompanyNotCreated => "CompanyNotCreated";
            public static string UserNotCreated => "UserNotCreated";
            public static string CompanyNotFound => "CompanyNotFound";
            public static string CompanyNotUpdated => "CompanyNotUpdated";
        }      
        
        public static class UserMessages
        {
            public static string UserNotFound => "UserNotFound";
            public static string LoginError => "LoginError";
            public static string UpdateError => "UpdateError";
            public static string UserNotCreated => "UserNotCreated";
            public static string UserNotDeleted => "UserNotDeleted";
            public static string UserNotDeletedYourself => "UserNotDeletedYourself";
        }

        public static class ProjectMessages
        {
            public static string ProjectAlreadyExists => "ProjectAlreadyExists";
            public static string ProjectNotCreated => "ProjectNotCreated";
            public static string ProjectNotFound => "ProjectNotFound";
            public static string ProjectNotDeleted => "ProjectNotDeleted";
            public static string NotFoundAssignedProject => "NotFoundAssingedProject";
            public static string ProjectNotUpdated => "ProjectNotUpdated";
        }

        public static class TopicMessages
        {
            public static string TopicNotCreated => "TopicNotCreated";
            public static string ProjectTopicsNotFound => "ProjectTopicsNotFound";
            public static string TopicNotFound => "TopicNotFound";
            public static string TopicNotUpdated => "TopicNotUpdated";
            public static string DefaultGroupNotDeleted => "DefaultTopicNotDeleted";
            public static string TopicNotDeleted => "TopicNotDeleted";
        }

        public static class ProjectUserMessages
        {
            public static string ProjectUserNotCreated => "ProjectUserNotCreated";
            public static string UnAuthorized => "UnAuthorized";
            public static string ProjectUsersNotFound => "ProjectUsersNotFound";
            public static string ProjectUserAlreadyExists => "ProjectUserAlreadyExists";
            public static string ProjectUserNotDeleted => "ProjectUserNotDeleted";
        }

        public static class SubscriptionMessages
        {
            public static string SubscriptionNotInserted => "SubscriptionNotInserted";
            public static string SubscriptionNotFound => "SubscriptionNotFound";
            public static string SubscriptionNotUpdated => "SubscriptionNotUpdated";
        }

        public static class NotificationMessage
        {
            public static string NotificationNotInserted => "NotificationNotInserted";
            public static string NotificaitonNotFound => "NotificationNotFound";
        }
        #endregion
    }
}
