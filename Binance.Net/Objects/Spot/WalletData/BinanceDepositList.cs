﻿using Binance.Net.Converters;
using Newtonsoft.Json;
using System;
using CryptoExchange.Net.Converters;
using Binance.Net.Enums;

namespace Binance.Net.Objects.Spot.WalletData
{
    /// <summary>
    /// Information about a deposit
    /// </summary>
    public class BinanceDeposit
    {
        /// <summary>
        /// Time the deposit was added to Binance
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime InsertTime { get; set; }
        /// <summary>
        /// The amount deposited
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// The coin deposited
        /// </summary>
        public string Coin { get; set; } = string.Empty;
        /// <summary>
        /// The address of the deposit
        /// </summary>
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// The tag of the address of the deposit
        /// </summary>
        public string Tag { get; set; } = string.Empty;
        /// <summary>
        /// The network
        /// </summary>
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// The transaction id
        /// </summary>
        [JsonProperty("txId")]
        public string TransactionId { get; set; } = string.Empty;
        /// <summary>
        /// The status of the deposit
        /// </summary>
        [JsonConverter(typeof(DepositStatusConverter))]
        public DepositStatus Status { get; set; }

        /// <summary>
        /// The transfer type
        /// </summary>
        [JsonConverter(typeof(WithdrawDepositTransferTypeConverter))]
        public WithdrawDepositTransferType TransferType { get; set; }

        /// <summary>
        /// Confirmations
        /// </summary>
        [JsonProperty("confirmTimes")]
        public string Confirmations { get; set; } = string.Empty;
        /// <summary>
        /// Network confirmations for unlocking
        /// </summary>
        [JsonProperty("unlockConfirm")]
        public string ConfirmationsForUnlock { get; set; } = string.Empty;
    }
}
