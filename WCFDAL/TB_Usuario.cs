
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WCFDAL
{

using System;
    using System.Collections.Generic;
    
public partial class TB_Usuario
{

    public TB_Usuario()
    {

        this.TB_Cliente = new HashSet<TB_Cliente>();

        this.TB_Perfil = new HashSet<TB_Perfil>();

    }


    public int ID_Usuario { get; set; }

    public string NombreCompleto { get; set; }

    public string NumeroDocumento { get; set; }

    public string NombreUsuario { get; set; }

    public string Contrasenia { get; set; }



    public virtual ICollection<TB_Cliente> TB_Cliente { get; set; }

    public virtual ICollection<TB_Perfil> TB_Perfil { get; set; }

}

}
