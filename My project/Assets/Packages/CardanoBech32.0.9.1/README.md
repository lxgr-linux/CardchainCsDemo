# CardanoBech32Wrapper based on bech32
## What is it ?
The CardanoBech32Wrapper is a C# Library which can be used to encode or decode bech32 strings.
This can be helpful if you want to see if multiple addresses belong to one stake key (e.g. wallet), even if they are not used yet on cardano.


## Current Possibilities
- Convert Bech32 format into Hex format
- Convert Hex format into Bech32 format
- Supported Cardano address types
  - Mainnet
    - addr1
    - pool1
    - stake1
  - Testnet
    - addr_test1
    - pool_test1
    - stake_test1
- No dependencies except for this library
- NetStandard 2.0

## Nuget Package
We created a Nuget Package called `CardanoBech32`.
You can find it [here](https://www.nuget.org/packages/CardanoBech32/)

## Github Repository
Code can be found [here](https://github.com/tigrpoolcom/CardanoBech32Wrapper).
Do a PR if you miss something or contact us.

## How to use
Check out our test cases to understand how to use it
- [CardanoBech32](https://github.com/tigrpoolcom/CardanoBech32Wrapper/blob/master/CardanoBech32Test/CardanoBech32Test.cs)
- [Helper](https://github.com/tigrpoolcom/CardanoBech32Wrapper/blob/master/CardanoBech32Test/HelperTest.cs)

## Embedded into API
You can use these functionalities now also via our CutyMals Cardano API.
Endpoint which provides the functionalities is `/api/CardanoTools`.

[Mainnet Cardano API](https://mainnet.cutymals.com/swagger)

[Testnet Cardano API](https://testnet.cutymals.com/swagger)

## Next Steps
- Include converter of PolicyId+Assetname into Asset Fingerprintsfingerprint

## Questions or problems ?
Contact us on [Twitter](https://mobile.twitter.com/cutymalscom) 
or directly on Github.