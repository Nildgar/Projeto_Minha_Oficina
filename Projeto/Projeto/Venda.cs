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
    
    public partial class Venda
    {
        public int IdVenda { get; set; }
        public System.DateTime Valor { get; set; }
        public string Estado { get; set; }
        public System.DateTime Data { get; set; }
        public int ClienteIdCliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual CarroVenda CarroVenda { get; set; }
    }
}
