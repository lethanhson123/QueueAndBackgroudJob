global using System.Text;

global using BusinessServices;
global using BusinessServices.Constants;
global using BusinessServices.Models.MessageQueueModel;
global using BusinessServices.Services.Interface.Version1;


global using Microsoft.Extensions.Logging.Configuration;
global using Microsoft.Extensions.Logging.EventLog;

global using Utilities.Helpers;
global using Utilities;

global using SubscribeNotSyncProducts;

global using Amazon.SQS.Model;
global using Newtonsoft.Json;
global using QueueEngine.Behaviors;
global using QueueEngine.Models.QueueSetting;
global using QueueEngine;
global using Google.Api;
global using Google.Type;