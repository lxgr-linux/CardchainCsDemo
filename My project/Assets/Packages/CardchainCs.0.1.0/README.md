# CardchainCs
Client library for crowdcontrol cardchain

## Usage
```c#
using CardchainCs.CardchainClient;

byte[] hex = new byte[32]
{
	176, 139, 181, 219, 136, 19, 183,
	176, 135, 218, 199, 231, 70, 249,
	129, 238, 212, 197, 207, 147, 217,
	51, 43, 217, 82, 136, 182, 245,
	189, 104, 186, 17
};  // Place byte publikKey here

var ccClient = new CardchainClient("http://localhost:1317/", "Testnet3", hex);
Console.Out.WriteLine(ccClient.SendMsgBuyCardScheme("10000000000000000000", "ucredits").Result);
```

## Development
### Build proto
```bash
git submodule sync
./gen_proto.sh
```