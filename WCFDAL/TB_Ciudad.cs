
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
    
public partial class TB_Ciudad
{

    public TB_Ciudad()
    {

        this.TB_Cliente = new HashSet<TB_Cliente>();

    }


    public int ID_Ciudad { get; set; }

    public string NombreCiudad { get; set; }

    public string NombreRegion { get; set; }



    public virtual ICollection<TB_Cliente> TB_Cliente { get; set; }

}

}