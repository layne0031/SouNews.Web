//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SouNews.DB
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class Article
    {
        public int id { get; set; }
        public string title { get; set; }
        public string contents { get; set; }
        public string type { get; set; }
        public string module { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<System.DateTime> addtime { get; set; }
        public string pic { get; set; }
    }
}
