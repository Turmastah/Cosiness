//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cosiness.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Order_List = new HashSet<Order_List>();
        }
    
        public int Product_ID { get; set; }
        public int Storage_ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> Image_ID { get; set; }
    
        public virtual Images Images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_List> Order_List { get; set; }
        public virtual Storage Storage { get; set; }
    }
}
