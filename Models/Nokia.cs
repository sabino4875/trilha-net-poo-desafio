namespace DesafioPOO.Models
{
    using System;
    // TODO: Herdar da classe "Smartphone"
    /// <summary>
    /// Classe que representa um smartphone nokia
    /// </summary>
    public class Nokia : Smartphone
    {
        /// <summary>
        /// Método construtor da classe
        /// </summary>
        public Nokia()
        {
        }

        /// <summary>
        /// Método construtor da classe
        /// </summary>
        /// <param name="numero">Número do smartphone</param>
        public Nokia(String numero) : base(numero)
        {
        }
        /// <summary>
        /// Classe base que representa um smartphone
        /// </summary>
        /// <param name="numero">Número do smartphone</param>
        /// <param name="modelo">Modelo do smartphone</param>
        /// <param name="iMEI">IMEI do smartphone</param>
        /// <param name="memoria">Quantidade de memória do smartphone</param>
        public Nokia(String numero, String modelo, String iMEI, Int32 memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        /// <summary>
        /// Método que simula a instalação de um smartphone nokia 
        /// </summary>
        /// <param name="nomeApp">Tipo de smartphone</param>
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(String nomeApp)
        {
            Console.WriteLine($"Instalando o smartphone {nomeApp} ...");
        }

    }
}