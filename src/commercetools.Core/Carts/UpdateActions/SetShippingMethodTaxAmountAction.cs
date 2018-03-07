﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using commercetools.Core.Common;

using Newtonsoft.Json;

namespace commercetools.Core.Carts.UpdateActions
{
    /// <summary>
    /// A shipping method tax amount can be set if the cart has the ExternalAmount TaxMode.
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api-projects-carts.html#set-shippingmethod-taxamount"/>
    public class SetShippingMethodTaxAmountAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// ExternalTaxAmount
        /// </summary>
        [JsonProperty(PropertyName = "externalTaxAmount")]
        public ExternalTaxAmountDraft ExternalTaxAmount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public SetShippingMethodTaxAmountAction()
        {
            this.Action = "setShippingMethodTaxAmount";
        }

        #endregion
    }
}
