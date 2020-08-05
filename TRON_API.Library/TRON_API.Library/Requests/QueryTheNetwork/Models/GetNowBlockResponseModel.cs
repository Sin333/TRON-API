using System;
using System.Text.Json.Serialization;
using TRON_API.Library.Requests.BaseModels;
using TRON_API.Library.Requests.QueryTheNetwork.Models.BaseModels;

namespace TRON_API.Library.Requests.QueryTheNetwork.Models
{
    public class GetNowBlockResponseModel
    {
        [JsonPropertyName("blockID")]
        public string BlockId { get; set; } 

        [JsonPropertyName("block_header")]
        public BaseBlockHeader<GetNowBlockBlockHeaderRawData> BlockHeader { get; set; } 

        [JsonPropertyName("transactions")]
        public GetNowBlockTransaction[] Transactions { get; set; } 
    }

    public class GetNowBlockBlockHeaderRawData : BaseBlockHeaderRawData
    {
        [JsonPropertyName("version")]
        public int Version { get; set; } 
    }

    #region transactions (39)
    
    public class GetNowBlockTransaction
    {
        [JsonPropertyName("ret")]
        public GetNowBlockRetModel[] Ret { get; set; } 

        [JsonPropertyName("signature")]
        public string[] Signature { get; set; } 

        [JsonPropertyName("txID")]
        public string TxId { get; set; } 

        [JsonPropertyName("raw_data")]
        public GetNowBlockTransactionRawData RawData { get; set; } 

        [JsonPropertyName("raw_data_hex")]
        public string RawDataHex { get; set; } 
    }
    
    public class GetNowBlockRetModel
    {
        [JsonPropertyName("contractRet")]
        public string ContractRet { get; set; } 
    }
    
    public class GetNowBlockTransactionRawData : TransactionRawData<GetNowBlockContract>
    {
        [JsonPropertyName("fee_limit")]
        public int? FeeLimit { get; set; } 
    }

    public class GetNowBlockContract : BaseTransactionContract
    {
        [JsonPropertyName("owner_address")]
        public string OwnerAddress { get; set; } 

        [JsonPropertyName("votes")]
        public GetNowBlockContractVoteModel[] Votes { get; set; } 

        [JsonPropertyName("data")]
        public string Data { get; set; } 

        [JsonPropertyName("contract_address")]
        public string ContractAddress { get; set; } 

        [JsonPropertyName("call_value")]
        public long? CallValue { get; set; } 

        [JsonPropertyName("account_address")]
        public string AccountAddress { get; set; } 

        [JsonPropertyName("amount")]
        public int? Amount { get; set; } 

        [JsonPropertyName("to_address")]
        public string ToAddress { get; set; } 
    }
    
    public class GetNowBlockContractVoteModel
    {
        [JsonPropertyName("vote_address")]
        public string VoteAddress { get; set; } 

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; } 
    }
    
    #endregion
}