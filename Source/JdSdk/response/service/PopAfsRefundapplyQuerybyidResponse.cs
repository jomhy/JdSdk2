﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Service.RefundapplySaf;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class PopAfsRefundapplyQuerybyidResponse : JdResponse
    {
        [JsonProperty("refundapplyResponse")]
        public RefundapplyResponse RefundapplyResponse
        {
            get;
            set;
        }

    }

}
