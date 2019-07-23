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

using System;
using System.Management.Automation;
using Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using ProjectResources = Microsoft.Azure.Commands.ResourceManager.Cmdlets.Properties.Resources;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation
{
    /// <summary>
    /// Creates a new deployment.
    /// </summary>
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Deployment", SupportsShouldProcess = true,
        DefaultParameterSetName = SubscriptionParameterSetWithParameterlessTemplateFile), OutputType(typeof(PSDeployment))]
    public class NewAzureDeploymentCmdlet : DeploymentCmdletWithParameters, IDynamicParameters
    {
        [Alias("DeploymentName")]
        [Parameter(Mandatory = false,
            HelpMessage = "The name of the deployment it's going to create. Only valid when a template is used. When a template is used, if the user doesn't specify a deployment name, use the current time, like \"20131223140835\".")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = TenantParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = TenantParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [LocationCompleter("Microsoft.Resources/resourceGroups")]
        [ValidateNotNullOrEmpty]
        public string Location { get; set; }

        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The management group id.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The management group id.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The management group id.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The management group id.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The management group id.")]
        [Parameter(ParameterSetName = ManagementGroupParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The management group id.")]
        [ValidateNotNullOrEmpty]
        public string ManagementGroupId { get; set; }

        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ParameterSetName = TenantParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, HelpMessage = "Create deployment at tenant scope if specified.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, HelpMessage = "Create deployment at tenant scope if specified.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateFileParameterObject,
            Mandatory = true, HelpMessage = "Create deployment at tenant scope if specified.")]
        [Parameter(ParameterSetName = TenantParameterSetWithTemplateFileParameterFile,
            Mandatory = true, HelpMessage = "Create deployment at tenant scope if specified.")]
        [Parameter(ParameterSetName = TenantParameterSetWithParameterlessTemplateObject,
            Mandatory = true, HelpMessage = "Create deployment at tenant scope if specified.")]
        [Parameter(ParameterSetName = TenantParameterSetWithParameterlessTemplateFile,
            Mandatory = true, HelpMessage = "Create deployment at tenant scope if specified.")]
        public SwitchParameter Tenant { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The deployment mode.")]
        public DeploymentMode Mode { get; set; }      

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The deployment debug log level.")]
        [ValidateSet("RequestContent", "ResponseContent", "All", "None", IgnoreCase = true)]
        public string DeploymentDebugLogLevel { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Rollback to the last successful deployment in the resource group, should not be present if -RollBackDeploymentName is used.")]
        public SwitchParameter RollbackToLastDeployment { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Rollback to the successful deployment with the given name in the resource group, should not be used if -RollbackToLastDeployment is used.")]
        public string RollBackDeploymentName { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            if (string.IsNullOrEmpty(this.ResourceGroupName) && this.Mode == DeploymentMode.Complete)
            {
                WriteExceptionError(new ArgumentException(ProjectResources.InvalidDeploymentMode));
            }

            if (this.RollbackToLastDeployment && !string.IsNullOrEmpty(this.RollBackDeploymentName))
            {
                WriteExceptionError(new ArgumentException(ProjectResources.InvalidRollbackParameters));
            }

            var parameters = new PSDeploymentCmdletParameters()
            {
                Location = this.Location,
                IsTenantScope = this.Tenant,
                ManagementGroupId = this.ManagementGroupId,
                ResourceGroupName = this.ResourceGroupName,
                DeploymentName = this.Name,
                DeploymentMode = this.Mode,
                TemplateFile = Uri.IsWellFormedUriString(this.TemplateFile, UriKind.Absolute) ? this.TemplateFile : this.TryResolvePath(this.TemplateFile),
                TemplateObject = TemplateObject,
                TemplateParameterObject = GetTemplateParameterObject(TemplateParameterObject),
                ParameterUri = Uri.IsWellFormedUriString(this.TemplateParameterFile, UriKind.Absolute) ? this.TemplateParameterFile : null,
                DeploymentDebugLogLevel = GetDeploymentDebugLogLevel(DeploymentDebugLogLevel),
                OnErrorDeployment = this.RollbackToLastDeployment || !string.IsNullOrEmpty(RollBackDeploymentName)
                    ? new OnErrorDeployment
                    {
                        Type = RollbackToLastDeployment ? OnErrorDeploymentType.LastSuccessful : OnErrorDeploymentType.SpecificDeployment,
                        DeploymentName = RollbackToLastDeployment ? null : RollBackDeploymentName
                    }
                    : null
            };

            if (!string.IsNullOrEmpty(parameters.DeploymentDebugLogLevel))
            {
                WriteWarning(ProjectResources.WarnOnDeploymentDebugSetting);
            }

            var deployment = ResourceManagerSdkClient.ExecuteDeployment(parameters);

            WriteObject(deployment);
        }
    }
}
