﻿// ----------------------------------------------------------------------------------
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
// ----------------------------------------------------------------------------------

using System.Collections;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation
{
    public abstract class DeploymentCmdletWithParameters : DeploymentCmdletBase
    {
        protected const string ResourceGroupParameterSetWithTemplateObjectParameterObject = "ResourceGroupWithTemplateObjectAndParameterObject";
        protected const string ResourceGroupParameterSetWithTemplateObjectParameterFile = "ResourceGroupWithTemplateObjectAndParameterFile";
        protected const string ResourceGroupParameterSetWithTemplateFileParameterObject = "ResourceGroupWithTemplateFileAndParameterObject";
        protected const string ResourceGroupParameterSetWithTemplateFileParameterFile = "ResourceGroupWithTemplateFileAndParameterFile";
        protected const string ResourceGroupParameterSetWithParameterlessTemplateObject = "ResourceGroupWithTemplateObjectAndNoParameters";
        protected const string ResourceGroupParameterSetWithParameterlessTemplateFile = "ResourceGroupWithTemplateFileWithAndNoParameters";

        protected const string SubscriptionParameterSetWithTemplateObjectParameterObject = "SubscriptionWithTemplateObjectAndParameterObject";
        protected const string SubscriptionParameterSetWithTemplateObjectParameterFile = "SubscriptionWithTemplateObjectAndParameterFile";
        protected const string SubscriptionParameterSetWithTemplateFileParameterObject = "SubscriptionWithTemplateFileAndParameterObject";
        protected const string SubscriptionParameterSetWithTemplateFileParameterFile = "SubscriptionWithTemplateFileAndParameterFile";
        protected const string SubscriptionParameterSetWithParameterlessTemplateObject = "SubscriptionWithTemplateObjectAndNoParameters";
        protected const string SubscriptionParameterSetWithParameterlessTemplateFile = "SubscriptionWithTemplateFileWithAndNoParameters";

        protected const string ManagementGroupParameterSetWithTemplateObjectParameterObject = "ManagementGroupWithTemplateObjectAndParameterObject";
        protected const string ManagementGroupParameterSetWithTemplateObjectParameterFile = "ManagementGroupWithTemplateObjectAndParameterFile";
        protected const string ManagementGroupParameterSetWithTemplateFileParameterObject = "ManagementGroupWithTemplateFileAndParameterObject";
        protected const string ManagementGroupParameterSetWithTemplateFileParameterFile = "ManagementGroupWithTemplateFileAndParameterFile";
        protected const string ManagementGroupParameterSetWithParameterlessTemplateObject = "ManagementGroupWithTemplateObjectAndNoParameters";
        protected const string ManagementGroupParameterSetWithParameterlessTemplateFile = "ManagementGroupWithTemplateFileWithAndNoParameters";

        protected const string TenantParameterSetWithTemplateObjectParameterObject = "TenantWithTemplateObjectAndParameterObject";
        protected const string TenantParameterSetWithTemplateObjectParameterFile = "TenantWithTemplateObjectAndParameterFile";
        protected const string TenantParameterSetWithTemplateFileParameterObject = "TenantWithTemplateFileAndParameterObject";
        protected const string TenantParameterSetWithTemplateFileParameterFile = "TenantWithTemplateFileAndParameterFile";
        protected const string TenantParameterSetWithParameterlessTemplateObject = "TenantWithTemplateObjectAndNoParameters";
        protected const string TenantParameterSetWithParameterlessTemplateFile = "TenantWithTemplateFileWithAndNoParameters";

        protected DeploymentCmdletWithParameters() : base()
        {
        }

        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the parameters.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the parameters.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the parameters.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the parameters.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the parameters.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the parameters.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the parameters.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the parameters.")]
        public override Hashtable TemplateParameterObject { get; set; }

        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A Uri or local path to the file that has the template parameters.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A Uri or local path to the file that has the template parameters.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A Uri or local path to the file that has the template parameters.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A Uri or local path to the file that has the template parameters.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A Uri or local path to the file that has the template parameters.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A Uri or local path to the file that has the template parameters.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A Uri or local path to the file that has the template parameters.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A Uri or local path to the file that has the template parameters.")]
        [ValidateNotNullOrEmpty]
        [Alias("TemplateParameterUri")]
        public override string TemplateParameterFile { get; set; }

        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [Parameter(ParameterSetName = TenantParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "A hash table which represents the template.")]
        [ValidateNotNull]
        public override Hashtable TemplateObject { get; set; }

        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [Parameter(ParameterSetName = TenantParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Uri or local path to the template file.")]
        [ValidateNotNullOrEmpty]
        [Alias("TemplateUri")]
        public override string TemplateFile { get; set; }
    }
}
