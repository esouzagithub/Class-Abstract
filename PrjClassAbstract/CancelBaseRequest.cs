using System;

namespace PrjClassAbstract {

    /// <summary>
    /// Classe base de cancelamento
    /// </summary>
    public class CancelBaseRequest : BaseRequest<CancelTransaction> {

        /// <summary>
        /// Método construtor
        /// </summary>
        public CancelBaseRequest() { }

        /// <summary>
        /// Número sequencial único
        /// </summary>
        public new long? UniqueSequentialNumber { get; set; }

    }
}