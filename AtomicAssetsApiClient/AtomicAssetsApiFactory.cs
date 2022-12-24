﻿using AtomicAssetsApiClient.Accounts;
using AtomicAssetsApiClient.Assets;
using AtomicAssetsApiClient.Burns;
using AtomicAssetsApiClient.Collections;
using AtomicAssetsApiClient.Config;
using AtomicAssetsApiClient.Offers;
using AtomicAssetsApiClient.Schemas;
using AtomicAssetsApiClient.Templates;
using AtomicAssetsApiClient.Transfers;

namespace AtomicAssetsApiClient
{
    public class AtomicAssetsApiFactory
    {
        private readonly string _baseUrl;
        private const string Version1BaseUrl = "http://wax.api.atomicassets.io/atomicassets/v1";

        private AtomicAssetsApiFactory(string baseUrl) => _baseUrl = baseUrl;

        /* It's a static property that returns a new instance of the AtomicAssetsApiFactory class. */
        public static AtomicAssetsApiFactory Version1 => new AtomicAssetsApiFactory(Version1BaseUrl);

        /// <summary>
        /// The AccountsApi function returns a new AccountsApi object, which is a class that inherits
        /// from the AccountsApiBase class
        /// </summary>
        /// <param name="_baseUrl">The base URL for the API.</param>
        public AccountsApi AccountsApi => new AccountsApi(_baseUrl);

        /// <summary>
        /// It creates a new instance of the AssetsApi class.
        /// </summary>
        /// <param name="_baseUrl">The base URL of the API.</param>
        public AssetsApi AssetsApi => new AssetsApi(_baseUrl);
        
        /// <summary>
        /// It creates a new BurnsApi object.
        /// </summary>
        /// <param name="_baseUrl">The base URL of the API.</param>
        public BurnsApi BurnsApi => new BurnsApi(_baseUrl);

        /// <summary>
        /// It creates a new instance of the CollectionsApi class.
        /// </summary>
        /// <param name="_baseUrl">The base URL for the API.</param>
        public CollectionsApi CollectionsApi => new CollectionsApi(_baseUrl);
        
        /// <summary>
        /// The ConfigApi function returns a new instance of the ConfigApi class, which is a class that
        /// is generated by the Swagger Codegen tool
        /// </summary>
        /// <param name="_baseUrl">The base URL of the API.</param>
        public ConfigApi ConfigApi => new ConfigApi(_baseUrl);
        
        /// <summary>
        /// It creates a new instance of the OffersApi class.
        /// </summary>
        /// <param name="_baseUrl">The base URL of the API.</param>
        public OffersApi OffersApi => new OffersApi(_baseUrl);

        /// <summary>
        /// It creates a new instance of the SchemasApi class.
        /// </summary>
        /// <param name="_baseUrl">The base URL of the API.</param>
        public SchemasApi SchemasApi => new SchemasApi(_baseUrl);
        
        /// <summary>
        /// It creates a new instance of the TemplatesApi class, passing in the baseUrl variable
        /// </summary>
        /// <param name="_baseUrl">The base URL of the API.</param>
        public TemplatesApi TemplatesApi => new TemplatesApi(_baseUrl);
        
        /// <summary>
        /// It creates a new instance of the TransfersApi class.
        /// </summary>
        /// <param name="_baseUrl">The base URL for the API.</param>
        public TransfersApi TransfersApi => new TransfersApi(_baseUrl);
    }
}
