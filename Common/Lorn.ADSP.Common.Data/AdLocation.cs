//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorn.ADSP.Common.DataModels
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// AdLocation
    /// </summary>
    public partial class AdLocation
    {
        partial void InitPKDefaultValues();
        public AdLocation()
        {
    		InitPKDefaultValues();
            this.AdPositions = new HashSet<AdPosition>();
    
    	}
        /// <summary>
        /// AdLocationId
        /// </summary>
        public System.Guid AdLocationId { get; set; }
        /// <summary>
        /// LocationName
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
    
         /// <summary>
        /// AdPositions
        /// </summary>
        public virtual ICollection<AdPosition> AdPositions { get; set; }
    }
}