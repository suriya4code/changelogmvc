using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace changelogmvc.Models
{
    public class changes
    {
        public ObjectId Id { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("Content")]
        public string Content { get; set; }

        [BsonElement("UpdatedDate")]
        public DateTime UpdatedDate { get; set; }

        [BsonElement("__v")]
        public decimal __v { get; set; }

    }
}
