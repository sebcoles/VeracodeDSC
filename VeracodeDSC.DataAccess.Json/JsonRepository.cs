﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VeracodeDSC.Shared;

namespace VeracodeDSC.DataAccess.Json
{
    public interface IJsonRepository
    {
        List<ApplicationProfile> Apps();       
    }

    public class JsonRepository : IJsonRepository
    {
        private List<ApplicationProfile> _apps;

        public JsonRepository(string filePath)
        {
            JsonConfig config;
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                config = JsonConvert.DeserializeObject<JsonConfig>(json);
            }
            _apps = config.application_profiles;
        }
        public List<ApplicationProfile> Apps()   
        {
            return _apps;
        }
    }
}
