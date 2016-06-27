using System;

namespace PrjClassAbstract {

    /// <summary>
    /// Dados da transação
    /// </summary>
    public class AuthorizationTransaction {

        /// <summary>
        /// Chave da transação
        /// </summary>
        public Guid TransactionKey { get; set; }

        /// <summary>
        /// Taxa da transação
        /// </summary>
        public short? TransactionFee { get; set; }

        /// <summary>
        /// Valor em centavos
        /// </summary>
        public long AmountInCents { get; set; }

        /// <summary>
        /// Dados do PIN
        /// </summary>
        public string PinData { get; set; }

        /// <summary>
        /// Dados do chip
        /// </summary>
        public string ChipData { get; set; }

        public string TransactionReference { get; set; }

    }
}