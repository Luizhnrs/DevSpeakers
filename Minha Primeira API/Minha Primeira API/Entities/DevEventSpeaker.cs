﻿namespace Minha_Primeira_API.Entities
{
    public class DevEventSpeaker
    {
        public Guid id { get; set; }
        public string Name { get; set; }

        public string TalkTitle { get; set; } 

        public string TalkDescription { get; set;}

        public string linkedinProfile { get; set; }
    }
}
