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
    
    public partial class Ddirection
    {
        public Ddirection()
        {
            this.TtypeCompetition = new HashSet<TtypeCompetition>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<TtypeCompetition> TtypeCompetition { get; set; }
    }
}