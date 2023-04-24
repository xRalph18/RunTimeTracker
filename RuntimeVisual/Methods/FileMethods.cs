﻿using Newtonsoft.Json;
using RunTimeTracker.Models;
using RuntimeVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeVisual.Methods
{
    class FileMethods
    {
        private static JsonSerializerSettings _settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
        private static string _timeDataPath = @"TimeData.json";
        private static string _likedDataPath = @"Liked.json";

        public static List<TimeSaveModel> ReadTime()
        {
            string timeDataString = File.ReadAllText(_timeDataPath);
            var timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(timeDataString, _settings) ?? new List<TimeSaveModel>();

            return timeData;
        }

        public static List<LikedModel> ReadLiked()
        {
            string likedDataString = File.ReadAllText(_likedDataPath);
            var likedData = JsonConvert.DeserializeObject<List<LikedModel>>(likedDataString, _settings) ?? new List<LikedModel>();

            return likedData;
        }
    }
}
