// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Monitoring.Alerts;
using Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models;

namespace Microsoft.WindowsAzure
{
    public static partial class RuleOperationsExtensions
    {
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Alerts.IRuleOperations.
        /// </param>
        /// <param name='parameters'>
        /// The rule to create or update.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse CreateOrUpdate(this IRuleOperations operations, RuleCreateOrUpdateParameters parameters)
        {
            try
            {
                return operations.CreateOrUpdateAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Alerts.IRuleOperations.
        /// </param>
        /// <param name='parameters'>
        /// The rule to create or update.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> CreateOrUpdateAsync(this IRuleOperations operations, RuleCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(parameters, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Alerts.IRuleOperations.
        /// </param>
        /// <param name='ruleId'>
        /// The id of the rule to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IRuleOperations operations, string ruleId)
        {
            try
            {
                return operations.DeleteAsync(ruleId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Alerts.IRuleOperations.
        /// </param>
        /// <param name='ruleId'>
        /// The id of the rule to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IRuleOperations operations, string ruleId)
        {
            return operations.DeleteAsync(ruleId, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Alerts.IRuleOperations.
        /// </param>
        /// <param name='ruleId'>
        /// The id of the rule to retrieve.
        /// </param>
        /// <returns>
        /// The Get Rule operation response.
        /// </returns>
        public static RuleGetResponse Get(this IRuleOperations operations, string ruleId)
        {
            try
            {
                return operations.GetAsync(ruleId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Alerts.IRuleOperations.
        /// </param>
        /// <param name='ruleId'>
        /// The id of the rule to retrieve.
        /// </param>
        /// <returns>
        /// The Get Rule operation response.
        /// </returns>
        public static Task<RuleGetResponse> GetAsync(this IRuleOperations operations, string ruleId)
        {
            return operations.GetAsync(ruleId, CancellationToken.None);
        }
        
        /// <summary>
        /// List the alert rules within a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Alerts.IRuleOperations.
        /// </param>
        /// <returns>
        /// The List Rules operation response.
        /// </returns>
        public static RuleListResponse List(this IRuleOperations operations)
        {
            try
            {
                return operations.ListAsync().Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// List the alert rules within a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Alerts.IRuleOperations.
        /// </param>
        /// <returns>
        /// The List Rules operation response.
        /// </returns>
        public static Task<RuleListResponse> ListAsync(this IRuleOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}
