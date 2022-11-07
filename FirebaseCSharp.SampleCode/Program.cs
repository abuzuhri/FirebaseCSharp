using FirebaseCSharp;
using FirebaseCSharp.Config;
using FirebaseCSharp.Interfaces;
using FirebaseCSharp.Response;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;


var configuration = new ConfigurationBuilder()
.AddUserSecrets<Program>()
.Build();



IFirebaseConfig config = new FirebaseConfig
{
    AuthSecret = configuration.GetSection("Firebase:AuthSecret").Value,
    BasePath = configuration.GetSection("Firebase:BasePath").Value
};

IFirebaseClient client = new FirebaseClient(config);

FirebaseResponse response = client.Get("Inventory");
var d = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Body);

