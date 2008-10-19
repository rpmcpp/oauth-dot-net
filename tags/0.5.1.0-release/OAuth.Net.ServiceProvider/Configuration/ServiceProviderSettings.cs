﻿// Copyright (c) 2008 Madgex
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
// OAuth.net uses the Windsor Container from the Castle Project. See "Castle 
// Project License.txt" in the Licenses folder.
// 
// Authors: Bruce Boughton, Chris Adams
// Website: http://lab.madgex.com/oauth-net/
// Email:   oauth-dot-net@madgex.com

using System.Configuration;
using OAuth.Net.Common;

namespace OAuth.Net.ServiceProvider
{
    public sealed class ServiceProviderSettings
        : ConfigurationSection
    {
        [ConfigurationProperty("ComponentsSection", IsRequired = false, DefaultValue = "oauth.net.serviceprovider")]
        public string ComponentsSection
        {
            get { return (string)this["ComponentsSection"]; }
            set { this["ComponentsSection"] = value; }
        }

        [ConfigurationProperty("AuthenticationRealm", IsRequired = true)]
        public string AuthenticationRealm
        {
            get { return (string)this["AuthenticationRealm"]; }
            set { this["AuthenticationRealm"] = value; }
        }

        #warning TODO: This is completely ignored at the moment! (never advertised)
        [ConfigurationProperty("AdvertiseOAuthSupport", IsRequired = false, DefaultValue = true)]
        public bool AdvertiseOAuthSupport
        {
            get { return (bool)this["AdvertiseOAuthSupport"]; }
            set { this["AdvertiseOAuthSupport"] = value; }
        }

        [ConfigurationProperty("ParameterSources", IsRequired = false, DefaultValue = OAuthParameterSources.ServiceProviderDefault)]
        public OAuthParameterSources ParameterSources
        {
            get { return (OAuthParameterSources)this["ParameterSources"]; }
            set { this["ParameterSources"] = value; }
        }

        [ConfigurationProperty("ImpersonateUserForProtectedResources", IsRequired = false, DefaultValue = true)]
        public bool ImpersonateUserForProtectedResources
        {
            get { return (bool)this["ImpersonateUserForProtectedResources"]; }
            set { this["ImpersonateUserForProtectedResources"] = value; }
        }

        [ConfigurationProperty("DummyIdentity", IsRequired = false, DefaultValue = "OAuthDummyIdentity")]
        public string DummyIdentity
        {
            get { return (string)this["DummyIdentity"]; }
            set { this["DummyIdentity"] = value; }
        }
    }
}