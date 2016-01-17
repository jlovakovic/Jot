﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace Jot.Storage.Serialization
{
    public class JsonSerializer : ISerializer
    {
        JavaScriptSerializer _serializer = new JavaScriptSerializer();

        public virtual string Serialize(object obj)
        {
            return _serializer.Serialize(obj);
        }

        public virtual object Deserialize(string serialized, Type originalType)
        {
            return _serializer.Deserialize(serialized, originalType);
        }
    }
}
