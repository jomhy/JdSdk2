﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Delivery.JobnoTraceJosService;

namespace JdSdk.Response.Delivery
{
﻿    [Serializable]
    public class EtmsEpartnerWaybillmissingQueryResponse : JdResponse
    {
        [JsonProperty("waybillMissingJosResult")]
        public WaybillMissingJosResult WaybillMissingJosResult
        {
            get;
            set;
        }

    }

}
