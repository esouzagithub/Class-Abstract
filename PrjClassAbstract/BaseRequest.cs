using System;

namespace PrjClassAbstract {

    /// <summary>
    /// Requisição base
    /// </summary>
    public abstract class BaseRequest<T> {

        /// <summary>
        /// Método construtor
        /// </summary>
        protected BaseRequest() {
            //Chave da requisição
            this.RequestKey = Guid.NewGuid();
            //Inicializa a data de criação
            this.CreateDate = DateTime.UtcNow;
        }

        /// <summary>
        /// Data de criação
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Chave da requisição
        /// </summary>
        public Guid RequestKey { get; set; }

        /// <summary>
        /// Número sequencial único
        /// </summary>
        public string UniqueSequentialNumber { get; set; }

        /// <summary>
        /// Transação Base
        /// </summary>
        public T Transaction{ get; set; }
    }
}