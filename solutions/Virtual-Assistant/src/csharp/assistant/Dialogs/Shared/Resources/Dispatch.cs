// <auto-generated>
// Code generated by LUISGen C:\Users\darrenj\source\repos\AI\solutions\Virtual-Assistant\src\csharp\assistant\DeploymentScripts\..\LocaleConfigurations\..\DeploymentScripts\en\dispatch.luis -cs Luis.Dispatch -o C:\Users\darrenj\source\repos\AI\solutions\Virtual-Assistant\src\csharp\assistant\DeploymentScripts\..\LocaleConfigurations\..\Dialogs\Shared\Resources
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
namespace Luis
{
    public class Dispatch: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            l_General, 
            l_Calendar, 
            l_Email, 
            l_ToDo, 
            l_PointOfInterest, 
            q_FAQ, 
            q_Chitchat, 
            l_News, 
            l_Restaurant, 
            l_Automotive, 
            None
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] ShopContent;
            public string[] TaskContentPattern;
            public string[] KEYWORD;
            public string[] ADDRESS;

            // Pattern.any
            public string[] topic;

            // Instance
            public class _Instance
            {
                public InstanceData[] ShopContent;
                public InstanceData[] TaskContentPattern;
                public InstanceData[] KEYWORD;
                public InstanceData[] ADDRESS;
                public InstanceData[] topic;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<Dispatch>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}
