﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Marketing;

namespace JdSdk.Request.Marketing
{
﻿    public class SellerPromotionActivitymodeGetRequest : JdRequestBase<SellerPromotionActivitymodeGetResponse>
    {
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.activitymode.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("promo_id" ,this.PromoId);
        }

    }

}
