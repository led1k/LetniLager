//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LetniLager
{
    using System;
    using System.Collections.Generic;
    
    public partial class accounting
    {
        public int Id { get; set; }
        public System.DateTime DateGame { get; set; }
        public int IdGroup { get; set; }
        public int IdTypeCompetition { get; set; }
        public decimal Evalution { get; set; }
    
        public virtual group group { get; set; }
        public virtual TtypeCompetition TtypeCompetition { get; set; }
    }
}