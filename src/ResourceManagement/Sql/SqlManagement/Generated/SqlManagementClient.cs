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
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public partial class SqlManagementClient : ServiceClient<SqlManagementClient>, ISqlManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private IAuditingPolicyOperations _auditingPolicy;
        
        /// <summary>
        /// Represents all the operations to manage Azure SQL Database and
        /// Database Server Audit policy.  Contains operations to: Create,
        /// Retrieve and Update audit policy.
        /// </summary>
        public virtual IAuditingPolicyOperations AuditingPolicy
        {
            get { return this._auditingPolicy; }
        }
        
        private IDatabaseActivationOperations _databaseActivation;
        
        /// <summary>
        /// Represents all the operations for operating pertaining to
        /// activation on Azure SQL Data Warehouse databases. Contains
        /// operations to: Pause and Resume databases
        /// </summary>
        public virtual IDatabaseActivationOperations DatabaseActivation
        {
            get { return this._databaseActivation; }
        }
        
        private IDatabaseBackupOperations _databaseBackup;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// restore points. Contains operations to: List restore points.
        /// </summary>
        public virtual IDatabaseBackupOperations DatabaseBackup
        {
            get { return this._databaseBackup; }
        }
        
        private IDatabaseOperations _databases;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Databases.
        /// Contains operations to: Create, Retrieve, Update, and Delete
        /// databases, and also includes the ability to get the event logs for
        /// a database.
        /// </summary>
        public virtual IDatabaseOperations Databases
        {
            get { return this._databases; }
        }
        
        private IDataMaskingOperations _dataMasking;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// data masking. Contains operations to: Create, Retrieve, Update,
        /// and Delete data masking rules, as well as Create, Retreive and
        /// Update data masking policy.
        /// </summary>
        public virtual IDataMaskingOperations DataMasking
        {
            get { return this._dataMasking; }
        }
        
        private IElasticPoolOperations _elasticPools;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Elastic Pools.  Contains operations to: Create, Retrieve, Update,
        /// and Delete.
        /// </summary>
        public virtual IElasticPoolOperations ElasticPools
        {
            get { return this._elasticPools; }
        }
        
        private IFirewallRuleOperations _firewallRules;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Server Firewall Rules.  Contains operations to: Create, Retrieve,
        /// Update, and Delete firewall rules.
        /// </summary>
        public virtual IFirewallRuleOperations FirewallRules
        {
            get { return this._firewallRules; }
        }
        
        private ILocationCapabilitiesOperations _locationCapabilities;
        
        /// <summary>
        /// Represents all the operations for determining the set of
        /// capabilites available in a specified region.
        /// </summary>
        public virtual ILocationCapabilitiesOperations LocationCapabilities
        {
            get { return this._locationCapabilities; }
        }
        
        private IRecommendedElasticPoolOperations _recommendedElasticPools;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL
        /// Recommended Elastic Pools.  Contains operations to: Retrieve.
        /// </summary>
        public virtual IRecommendedElasticPoolOperations RecommendedElasticPools
        {
            get { return this._recommendedElasticPools; }
        }
        
        private IRecommendedIndexOperations _recommendedIndexes;
        
        /// <summary>
        /// Represents all the operations for managing recommended indexes on
        /// Azure SQL Databases. Contains operations to retrieve recommended
        /// index and update state.
        /// </summary>
        public virtual IRecommendedIndexOperations RecommendedIndexes
        {
            get { return this._recommendedIndexes; }
        }
        
        private IReplicationLinkOperations _databaseReplicationLinks;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Replication Links.  Contains operations to: Delete and Retrieve
        /// replication links.
        /// </summary>
        public virtual IReplicationLinkOperations DatabaseReplicationLinks
        {
            get { return this._databaseReplicationLinks; }
        }
        
        private ISecureConnectionPolicyOperations _secureConnection;
        
        /// <summary>
        /// Represents all the operations for managing Azure SQL Database
        /// secure connection.  Contains operations to: Create, Retrieve and
        /// Update secure connection policy .
        /// </summary>
        public virtual ISecureConnectionPolicyOperations SecureConnection
        {
            get { return this._secureConnection; }
        }
        
        private IServerAdministratorOperations _serverAdministrators;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Server
        /// Active Directory Administrators.  Contains operations to: Create,
        /// Retrieve, Update, and Delete Azure SQL Server Active Directory
        /// Administrators.
        /// </summary>
        public virtual IServerAdministratorOperations ServerAdministrators
        {
            get { return this._serverAdministrators; }
        }
        
        private IServerOperations _servers;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Servers.  Contains operations to: Create, Retrieve, Update, and
        /// Delete servers.
        /// </summary>
        public virtual IServerOperations Servers
        {
            get { return this._servers; }
        }
        
        private IServerUpgradeOperations _serverUpgrades;
        
        /// <summary>
        /// Represents all the operations for Azure SQL Database Server Upgrade
        /// </summary>
        public virtual IServerUpgradeOperations ServerUpgrades
        {
            get { return this._serverUpgrades; }
        }
        
        private IServiceObjectiveOperations _serviceObjectives;
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Service Objectives.   Contains operations to: Retrieve service
        /// objectives.
        /// </summary>
        public virtual IServiceObjectiveOperations ServiceObjectives
        {
            get { return this._serviceObjectives; }
        }
        
        private IServiceTierAdvisorOperations _serviceTierAdvisors;
        
        /// <summary>
        /// Represents all the operations for operating on service tier
        /// advisors.  Contains operations to: Retrieve.
        /// </summary>
        public virtual IServiceTierAdvisorOperations ServiceTierAdvisors
        {
            get { return this._serviceTierAdvisors; }
        }
        
        private ITransparentDataEncryptionOperations _transparentDataEncryption;
        
        /// <summary>
        /// Represents all the operations of Azure SQL Database Transparent
        /// Data Encryption.  Contains operations to: Retrieve, and Update
        /// Transparent Data Encryption.
        /// </summary>
        public virtual ITransparentDataEncryptionOperations TransparentDataEncryption
        {
            get { return this._transparentDataEncryption; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        public SqlManagementClient()
            : base()
        {
            this._auditingPolicy = new AuditingPolicyOperations(this);
            this._databaseActivation = new DatabaseActivationOperations(this);
            this._databaseBackup = new DatabaseBackupOperations(this);
            this._databases = new DatabaseOperations(this);
            this._dataMasking = new DataMaskingOperations(this);
            this._elasticPools = new ElasticPoolOperations(this);
            this._firewallRules = new FirewallRuleOperations(this);
            this._locationCapabilities = new LocationCapabilitiesOperations(this);
            this._recommendedElasticPools = new RecommendedElasticPoolOperations(this);
            this._recommendedIndexes = new RecommendedIndexOperations(this);
            this._databaseReplicationLinks = new ReplicationLinkOperations(this);
            this._secureConnection = new SecureConnectionPolicyOperations(this);
            this._serverAdministrators = new ServerAdministratorOperations(this);
            this._servers = new ServerOperations(this);
            this._serverUpgrades = new ServerUpgradeOperations(this);
            this._serviceObjectives = new ServiceObjectiveOperations(this);
            this._serviceTierAdvisors = new ServiceTierAdvisorOperations(this);
            this._transparentDataEncryption = new TransparentDataEncryptionOperations(this);
            this._apiVersion = "2014-04-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public SqlManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public SqlManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SqlManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._auditingPolicy = new AuditingPolicyOperations(this);
            this._databaseActivation = new DatabaseActivationOperations(this);
            this._databaseBackup = new DatabaseBackupOperations(this);
            this._databases = new DatabaseOperations(this);
            this._dataMasking = new DataMaskingOperations(this);
            this._elasticPools = new ElasticPoolOperations(this);
            this._firewallRules = new FirewallRuleOperations(this);
            this._locationCapabilities = new LocationCapabilitiesOperations(this);
            this._recommendedElasticPools = new RecommendedElasticPoolOperations(this);
            this._recommendedIndexes = new RecommendedIndexOperations(this);
            this._databaseReplicationLinks = new ReplicationLinkOperations(this);
            this._secureConnection = new SecureConnectionPolicyOperations(this);
            this._serverAdministrators = new ServerAdministratorOperations(this);
            this._servers = new ServerOperations(this);
            this._serverUpgrades = new ServerUpgradeOperations(this);
            this._serviceObjectives = new ServiceObjectiveOperations(this);
            this._serviceTierAdvisors = new ServiceTierAdvisorOperations(this);
            this._transparentDataEncryption = new TransparentDataEncryptionOperations(this);
            this._apiVersion = "2014-04-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SqlManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SqlManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// SqlManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of SqlManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<SqlManagementClient> client)
        {
            base.Clone(client);
            
            if (client is SqlManagementClient)
            {
                SqlManagementClient clonedClient = ((SqlManagementClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
