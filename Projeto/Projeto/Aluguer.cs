//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aluguer
    {
        public int IdAluguer { get; set; }
        public System.DateTime DataInicio { get; set; }
        public System.DateTime DataFim { get; set; }
        public decimal Valor { get; set; }
        public decimal Kms { get; set; }
        public int ClienteIdCliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual CarroAluguer CarroAluguer { get; set; }
    }
}
