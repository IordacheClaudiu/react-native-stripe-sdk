using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Stripe.Sdk.RNStripeSdk
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNStripeSdkModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNStripeSdkModule"/>.
        /// </summary>
        internal RNStripeSdkModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNStripeSdk";
            }
        }
    }
}
