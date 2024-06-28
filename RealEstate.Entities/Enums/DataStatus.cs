using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities.Enums
{
    /// <summary>
    /// Verinin durumunu temsil eden enum.
    /// </summary>
    public enum DataStatus
    {
        /// <summary>
        /// Verinin yeni eklendiğini belirtir.
        /// </summary>
        Inserted = 1,
        /// <summary>
        /// Verinin güncellendiğini belirtir.
        /// </summary>
        Updated = 2,
        /// <summary>
        /// Verinin silindiğini belirtir.
        /// </summary>
        Deleted = 3
    }
}