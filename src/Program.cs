using System.Net;
using CardchainCs.CardchainClient;
using Cosmcs.Crypto.Secp256k1;
using DecentralCardGame.Cardchain.Cardchain;
using Google.Protobuf;


System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
byte[] hex = new byte[32]
{
    176, 139, 181, 219, 136, 19, 183,
    176, 135, 218, 199, 231, 70, 249,
    129, 238, 212, 107, 207, 147, 217,
    51, 43, 217, 82, 136, 182, 245,
    189, 104, 186, 16
};  // Place byte publikKey here

var privateKey = new PrivateKey(hex);
var accoutAddress = privateKey.PublicKey().AccountId("cc");
Console.Out.WriteLine(accoutAddress);


var ccClient = new CardchainClient("http://lxgr.xyz:9090", "cardtestnet-4", hex);
//var resp = ccClient.SendMsgBuyCardScheme("10000000000000000000", "ucredits").Result;
//var resp = ccClient.SendMsgCreateCollection("jaja", accoutAddress.ToString(), accoutAddress.ToString(), new string[]{}).Result;
try {
    var resp = ccClient.SendMsgExecMsgVoteCard("cc14km80077s0hch3sh38wh2hfk7kxfau4456r3ej", 431, "overpowered").Result;
    Console.Out.WriteLine(resp.ClientResponse.RawResponse);
    foreach (var respResponseMessage in resp.ResponseMessages)
    {
        Console.Out.WriteLine(JsonFormatter.Default.Format(respResponseMessage));
    }
} catch
{
}
var resp2 = ccClient.SendMsgExecMsgVoteCard("cc14km80077s0hch3sh38wh2hfk7kxfau4456r3ej", 432, "overpowered").Result;
Console.Out.WriteLine(resp2.ClientResponse.RawResponse);
foreach (var respResponseMessage in resp2.ResponseMessages)
{
    Console.Out.WriteLine(JsonFormatter.Default.Format(respResponseMessage));
}