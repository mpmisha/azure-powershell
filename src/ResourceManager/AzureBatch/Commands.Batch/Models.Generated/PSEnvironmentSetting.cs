﻿// -----------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{


    public class PSEnvironmentSetting
    {

        internal Microsoft.Azure.Batch.EnvironmentSetting omObject;

        public PSEnvironmentSetting(string name, string value)
        {
            this.omObject = new Microsoft.Azure.Batch.EnvironmentSetting(name, value);
        }

        internal PSEnvironmentSetting(Microsoft.Azure.Batch.EnvironmentSetting omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }

        public string Name
        {
            get
            {
                return this.omObject.Name;
            }
        }

        public string Value
        {
            get
            {
                return this.omObject.Value;
            }
        }
    }
}
