using CardchainCs.CardchainClient;
using Google.Protobuf;
using UnityEngine;

public class Chain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        byte[] hex = new byte[32]
        {
            176, 139, 181, 219, 136, 19, 183,
            176, 135, 218, 199, 231, 70, 249,
            129, 238, 212, 107, 207, 147, 217,
            51, 43, 217, 82, 136, 182, 245,
            189, 104, 186, 17
        };  // Place byte publikKey here

        var ccClient = new CardchainClient("http://lxgr.xyz:9090", "Testnet3", hex);
        var resp = ccClient.SendMsgBuyCardScheme("10000000000000000000", "ucredits").Result;
        Debug.Log(resp.RawResponse);
        if (resp.ResponseMessage != null)
        {
            Debug.Log(JsonFormatter.Default.Format(resp.ResponseMessage));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
