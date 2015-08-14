using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    
    public interface IOauthApi
    {
        
        /// <summary>
        /// Access Token Client provides authorization token obtained from /api/oauth2/authorize to this endpoint and receives an access token. Access token can then be used to query different API endpoints of QuantiModo.
        /// </summary>
        /// <param name="clientId">Client id</param>
        /// <param name="clientSecret">Client secret</param>
        /// <param name="grantType">Grant Type can be &#39;authorization_code&#39; or &#39;refresh_token&#39;</param>
        /// <param name="responseType">Response type</param>
        /// <param name="scope">Scope</param>
        /// <param name="redirectUri">Redirect uri</param>
        /// <param name="state">State</param>
        /// <param name="realm">Realm</param>
        /// <returns></returns>
        void Oauth2AccesstokenGet (string clientId, string clientSecret, string grantType, string responseType, string scope, string redirectUri, string state, string realm);
  
        /// <summary>
        /// Access Token Client provides authorization token obtained from /api/oauth2/authorize to this endpoint and receives an access token. Access token can then be used to query different API endpoints of QuantiModo.
        /// </summary>
        /// <param name="clientId">Client id</param>
        /// <param name="clientSecret">Client secret</param>
        /// <param name="grantType">Grant Type can be &#39;authorization_code&#39; or &#39;refresh_token&#39;</param>
        /// <param name="responseType">Response type</param>
        /// <param name="scope">Scope</param>
        /// <param name="redirectUri">Redirect uri</param>
        /// <param name="state">State</param>
        /// <param name="realm">Realm</param>
        /// <returns></returns>
        System.Threading.Tasks.Task Oauth2AccesstokenGetAsync (string clientId, string clientSecret, string grantType, string responseType, string scope, string redirectUri, string state, string realm);
        
        /// <summary>
        /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM account. It will redirect the user to the url provided by the client application with the code as a query parameter or error in case of an error.
        /// </summary>
        /// <param name="clientId">This is the unique ID that QuantiModo uses to identify your application. Obtain a client id by emailing info@quantimo.do.</param>
        /// <param name="clientSecret">This is the secret for your obtained clietn_id. QuantiModo uses this to validate that only your application uses the client_id.</param>
        /// <param name="responseType">If the value is code, launches a Basic flow, requiring a POST to the token endpoint to obtain the tokens. If the value is token id_token or id_token token, launches an Implicit flow, requiring the use of Javascript at the redirect URI to retrieve tokens from the URI #fragment.</param>
        /// <param name="scope">Scopes include basic, readmeasurements, and writemeasurements. The \&quot;basic\&quot; scope allows you to read user info (displayname, email, etc). The \&quot;readmeasurements\&quot; scope allows one to read a user&#39;s data. The \&quot;writemeasurements\&quot; scope allows you to write user data. Separate multiple scopes by a space.</param>
        /// <param name="redirectUri">The redirect URI is the URL within your client application that will receive the OAuth2 credentials.</param>
        /// <param name="state">An opaque string that is round-tripped in the protocol; that is to say, it is returned as a URI parameter in the Basic flow, and in the URI</param>
        /// <param name="realm">Name of the realm representing the users of your distributed applications and services. A \&quot;realm\&quot; attribute MAY be included to indicate the scope of protection.</param>
        /// <returns></returns>
        void Oauth2AuthorizeGet (string clientId, string clientSecret, string responseType, string scope, string redirectUri, string state, string realm);
  
        /// <summary>
        /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM account. It will redirect the user to the url provided by the client application with the code as a query parameter or error in case of an error.
        /// </summary>
        /// <param name="clientId">This is the unique ID that QuantiModo uses to identify your application. Obtain a client id by emailing info@quantimo.do.</param>
        /// <param name="clientSecret">This is the secret for your obtained clietn_id. QuantiModo uses this to validate that only your application uses the client_id.</param>
        /// <param name="responseType">If the value is code, launches a Basic flow, requiring a POST to the token endpoint to obtain the tokens. If the value is token id_token or id_token token, launches an Implicit flow, requiring the use of Javascript at the redirect URI to retrieve tokens from the URI #fragment.</param>
        /// <param name="scope">Scopes include basic, readmeasurements, and writemeasurements. The \&quot;basic\&quot; scope allows you to read user info (displayname, email, etc). The \&quot;readmeasurements\&quot; scope allows one to read a user&#39;s data. The \&quot;writemeasurements\&quot; scope allows you to write user data. Separate multiple scopes by a space.</param>
        /// <param name="redirectUri">The redirect URI is the URL within your client application that will receive the OAuth2 credentials.</param>
        /// <param name="state">An opaque string that is round-tripped in the protocol; that is to say, it is returned as a URI parameter in the Basic flow, and in the URI</param>
        /// <param name="realm">Name of the realm representing the users of your distributed applications and services. A \&quot;realm\&quot; attribute MAY be included to indicate the scope of protection.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task Oauth2AuthorizeGetAsync (string clientId, string clientSecret, string responseType, string scope, string redirectUri, string state, string realm);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OauthApi : IOauthApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OauthApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OauthApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OauthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OauthApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Access Token Client provides authorization token obtained from /api/oauth2/authorize to this endpoint and receives an access token. Access token can then be used to query different API endpoints of QuantiModo.
        /// </summary>
        /// <param name="clientId">Client id</param> 
        /// <param name="clientSecret">Client secret</param> 
        /// <param name="grantType">Grant Type can be &#39;authorization_code&#39; or &#39;refresh_token&#39;</param> 
        /// <param name="responseType">Response type</param> 
        /// <param name="scope">Scope</param> 
        /// <param name="redirectUri">Redirect uri</param> 
        /// <param name="state">State</param> 
        /// <param name="realm">Realm</param> 
        /// <returns></returns>            
        public void Oauth2AccesstokenGet (string clientId, string clientSecret, string grantType, string responseType, string scope, string redirectUri, string state, string realm)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling Oauth2AccesstokenGet");
            
            // verify the required parameter 'clientSecret' is set
            if (clientSecret == null) throw new ApiException(400, "Missing required parameter 'clientSecret' when calling Oauth2AccesstokenGet");
            
            // verify the required parameter 'grantType' is set
            if (grantType == null) throw new ApiException(400, "Missing required parameter 'grantType' when calling Oauth2AccesstokenGet");
            
    
            var path = "/oauth2/accesstoken";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (clientSecret != null) queryParams.Add("client_secret", ApiClient.ParameterToString(clientSecret)); // query parameter
            if (grantType != null) queryParams.Add("grant_type", ApiClient.ParameterToString(grantType)); // query parameter
            if (responseType != null) queryParams.Add("response_type", ApiClient.ParameterToString(responseType)); // query parameter
            if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
            if (redirectUri != null) queryParams.Add("redirect_uri", ApiClient.ParameterToString(redirectUri)); // query parameter
            if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
            if (realm != null) queryParams.Add("realm", ApiClient.ParameterToString(realm)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AccesstokenGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AccesstokenGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Access Token Client provides authorization token obtained from /api/oauth2/authorize to this endpoint and receives an access token. Access token can then be used to query different API endpoints of QuantiModo.
        /// </summary>
        /// <param name="clientId">Client id</param>
        /// <param name="clientSecret">Client secret</param>
        /// <param name="grantType">Grant Type can be &#39;authorization_code&#39; or &#39;refresh_token&#39;</param>
        /// <param name="responseType">Response type</param>
        /// <param name="scope">Scope</param>
        /// <param name="redirectUri">Redirect uri</param>
        /// <param name="state">State</param>
        /// <param name="realm">Realm</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task Oauth2AccesstokenGetAsync (string clientId, string clientSecret, string grantType, string responseType, string scope, string redirectUri, string state, string realm)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling Oauth2AccesstokenGet");
            // verify the required parameter 'clientSecret' is set
            if (clientSecret == null) throw new ApiException(400, "Missing required parameter 'clientSecret' when calling Oauth2AccesstokenGet");
            // verify the required parameter 'grantType' is set
            if (grantType == null) throw new ApiException(400, "Missing required parameter 'grantType' when calling Oauth2AccesstokenGet");
            
    
            var path = "/oauth2/accesstoken";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (clientSecret != null) queryParams.Add("client_secret", ApiClient.ParameterToString(clientSecret)); // query parameter
            if (grantType != null) queryParams.Add("grant_type", ApiClient.ParameterToString(grantType)); // query parameter
            if (responseType != null) queryParams.Add("response_type", ApiClient.ParameterToString(responseType)); // query parameter
            if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
            if (redirectUri != null) queryParams.Add("redirect_uri", ApiClient.ParameterToString(redirectUri)); // query parameter
            if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
            if (realm != null) queryParams.Add("realm", ApiClient.ParameterToString(realm)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AccesstokenGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM account. It will redirect the user to the url provided by the client application with the code as a query parameter or error in case of an error.
        /// </summary>
        /// <param name="clientId">This is the unique ID that QuantiModo uses to identify your application. Obtain a client id by emailing info@quantimo.do.</param> 
        /// <param name="clientSecret">This is the secret for your obtained clietn_id. QuantiModo uses this to validate that only your application uses the client_id.</param> 
        /// <param name="responseType">If the value is code, launches a Basic flow, requiring a POST to the token endpoint to obtain the tokens. If the value is token id_token or id_token token, launches an Implicit flow, requiring the use of Javascript at the redirect URI to retrieve tokens from the URI #fragment.</param> 
        /// <param name="scope">Scopes include basic, readmeasurements, and writemeasurements. The \&quot;basic\&quot; scope allows you to read user info (displayname, email, etc). The \&quot;readmeasurements\&quot; scope allows one to read a user&#39;s data. The \&quot;writemeasurements\&quot; scope allows you to write user data. Separate multiple scopes by a space.</param> 
        /// <param name="redirectUri">The redirect URI is the URL within your client application that will receive the OAuth2 credentials.</param> 
        /// <param name="state">An opaque string that is round-tripped in the protocol; that is to say, it is returned as a URI parameter in the Basic flow, and in the URI</param> 
        /// <param name="realm">Name of the realm representing the users of your distributed applications and services. A \&quot;realm\&quot; attribute MAY be included to indicate the scope of protection.</param> 
        /// <returns></returns>            
        public void Oauth2AuthorizeGet (string clientId, string clientSecret, string responseType, string scope, string redirectUri, string state, string realm)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling Oauth2AuthorizeGet");
            
            // verify the required parameter 'clientSecret' is set
            if (clientSecret == null) throw new ApiException(400, "Missing required parameter 'clientSecret' when calling Oauth2AuthorizeGet");
            
            // verify the required parameter 'responseType' is set
            if (responseType == null) throw new ApiException(400, "Missing required parameter 'responseType' when calling Oauth2AuthorizeGet");
            
            // verify the required parameter 'scope' is set
            if (scope == null) throw new ApiException(400, "Missing required parameter 'scope' when calling Oauth2AuthorizeGet");
            
    
            var path = "/oauth2/authorize";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (clientSecret != null) queryParams.Add("client_secret", ApiClient.ParameterToString(clientSecret)); // query parameter
            if (responseType != null) queryParams.Add("response_type", ApiClient.ParameterToString(responseType)); // query parameter
            if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
            if (redirectUri != null) queryParams.Add("redirect_uri", ApiClient.ParameterToString(redirectUri)); // query parameter
            if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
            if (realm != null) queryParams.Add("realm", ApiClient.ParameterToString(realm)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AuthorizeGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AuthorizeGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM account. It will redirect the user to the url provided by the client application with the code as a query parameter or error in case of an error.
        /// </summary>
        /// <param name="clientId">This is the unique ID that QuantiModo uses to identify your application. Obtain a client id by emailing info@quantimo.do.</param>
        /// <param name="clientSecret">This is the secret for your obtained clietn_id. QuantiModo uses this to validate that only your application uses the client_id.</param>
        /// <param name="responseType">If the value is code, launches a Basic flow, requiring a POST to the token endpoint to obtain the tokens. If the value is token id_token or id_token token, launches an Implicit flow, requiring the use of Javascript at the redirect URI to retrieve tokens from the URI #fragment.</param>
        /// <param name="scope">Scopes include basic, readmeasurements, and writemeasurements. The \&quot;basic\&quot; scope allows you to read user info (displayname, email, etc). The \&quot;readmeasurements\&quot; scope allows one to read a user&#39;s data. The \&quot;writemeasurements\&quot; scope allows you to write user data. Separate multiple scopes by a space.</param>
        /// <param name="redirectUri">The redirect URI is the URL within your client application that will receive the OAuth2 credentials.</param>
        /// <param name="state">An opaque string that is round-tripped in the protocol; that is to say, it is returned as a URI parameter in the Basic flow, and in the URI</param>
        /// <param name="realm">Name of the realm representing the users of your distributed applications and services. A \&quot;realm\&quot; attribute MAY be included to indicate the scope of protection.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task Oauth2AuthorizeGetAsync (string clientId, string clientSecret, string responseType, string scope, string redirectUri, string state, string realm)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling Oauth2AuthorizeGet");
            // verify the required parameter 'clientSecret' is set
            if (clientSecret == null) throw new ApiException(400, "Missing required parameter 'clientSecret' when calling Oauth2AuthorizeGet");
            // verify the required parameter 'responseType' is set
            if (responseType == null) throw new ApiException(400, "Missing required parameter 'responseType' when calling Oauth2AuthorizeGet");
            // verify the required parameter 'scope' is set
            if (scope == null) throw new ApiException(400, "Missing required parameter 'scope' when calling Oauth2AuthorizeGet");
            
    
            var path = "/oauth2/authorize";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (clientSecret != null) queryParams.Add("client_secret", ApiClient.ParameterToString(clientSecret)); // query parameter
            if (responseType != null) queryParams.Add("response_type", ApiClient.ParameterToString(responseType)); // query parameter
            if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
            if (redirectUri != null) queryParams.Add("redirect_uri", ApiClient.ParameterToString(redirectUri)); // query parameter
            if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
            if (realm != null) queryParams.Add("realm", ApiClient.ParameterToString(realm)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AuthorizeGet: " + response.Content, response.Content);

            
            return;
        }
        
    }
    
}
