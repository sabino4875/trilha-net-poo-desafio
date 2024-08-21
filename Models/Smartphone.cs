namespace DesafioPOO.Models
{
    using System;

    /// <summary>
    /// Classe base que representa um smartphone
    /// </summary>
    /// <param name="numero">Número do smartphone</param>
    /// <param name="modelo">Modelo do smartphone</param>
    /// <param name="iMEI">IMEI do smartphone</param>
    /// <param name="memoria">Quantidade de memória do smartphone</param>
    // TODO: Passar os parâmetros do construtor para as propriedades
    public abstract class Smartphone(String numero, String modelo, String iMEI, Int32 memoria)
    {
        //recursos da classe
        private readonly String _fazerChamada = "Ligando...";
        private readonly String _receberChamada = "Recebendo ligação...";

        /// <summary>
        /// Método construtor da classe
        /// </summary>
        /// <param name="numero">Número do smartphone</param>
        protected Smartphone(string numero) : this(numero, String.Empty, String.Empty, 0)
        {
        }

        /// <summary>
        /// Método construtor da classe
        /// </summary>
        protected Smartphone() : this(String.Empty, String.Empty, String.Empty, 0)
        {
        }

        /// <summary>
        /// Número do smartphone
        /// </summary>
        public String Numero { get; set; } = numero;
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        /// <summary>
        /// Modelo do smartphone
        /// </summary>
        public String Modelo { get; set; } = modelo;

        /// <summary>
        /// IMEI do smartphone
        /// </summary>
        public String IMEI { get; set; } = iMEI;

        /// <summary>
        /// Quantidade de memória do smartphone
        /// </summary>
        public Int32 Memoria { get; set; } = memoria;

        /// <summary>
        /// Método que simula uma ligação
        /// </summary>
        public void Ligar()
        {
            Console.WriteLine(_fazerChamada);
        }

        /// <summary>
        /// Método que simula o recebimento de uma ligação
        /// </summary>
        public void ReceberLigacao()
        {
            Console.WriteLine(_receberChamada);
        }

        /// <summary>
        /// Método que simula a instalação do smartphone
        /// </summary>
        /// <param name="nomeApp"></param>
        public abstract void InstalarAplicativo(String nomeApp);
    }
}