using System;

namespace PrjClassAbstract {

    /// <summary>
    /// Classe base de desfazimento
    /// </summary>
    public class ReversalBaseRequest : BaseRequest<ReversalTransaction> {

        /// <summary>
        /// Método construtor
        /// </summary>
        public ReversalBaseRequest() { }

        /// <summary>
        /// Número sequencial único
        /// </summary>
        public new long? UniqueSequentialNumber { get; set; }

    }
}