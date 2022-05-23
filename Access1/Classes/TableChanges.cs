using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access1.Classes
{
    using System.Collections.Generic;
    using System.Data;

    namespace BaseLibrary
    {
        /// <summary> 
        /// Used for the language extension method AllChanges above 
        /// </summary> 
        public class TableChanges
        {
            /// <summary> 
            /// Indicates the DataTable has one or more deleted rows 
            /// </summary> 
            /// <returns></returns> 
            public bool HasDeleted { get; set; }
            /// <summary> 
            /// DataTable contains all deleted rows 
            /// </summary> 
            /// <returns></returns> 
            public DataTable Deleted { get; set; }
            private List<int> _deletedPrimaryKeys = new List<int>();
            public List<int> DeletedPrimaryKeys
            {
                get => _deletedPrimaryKeys;
                set => _deletedPrimaryKeys = value;
            }
            /// <summary> 
            /// Indicates the DataTable has one ore more modified rows 
            /// </summary> 
            /// <returns></returns> 
            public bool HasModified { get; set; }
            /// <summary> 
            /// DataTable contains all modified rows 
            /// </summary> 
            /// <returns></returns> 
            public DataTable Modified { get; set; }
            /// <summary> 
            /// Indicates the DataTable has one or more new rows 
            /// </summary> 
            /// <returns></returns> 
            public bool HasNew { get; set; }
            /// <summary> 
            /// DataTable containing new rows 
            /// </summary> 
            /// <returns></returns> 
            /// <remarks>Will not have the new primary key</remarks> 
            public DataTable Added { get; set; }
            /// <summary> 
            /// Indicates if there are any unchanged rows 
            /// </summary> 
            /// <returns></returns> 
            public bool HasUnchanged { get; set; }
            /// <summary> 
            /// DataTable containing unchanged rows 
            /// </summary> 
            /// <returns></returns> 
            public DataTable UnChanged { get; set; }
            /// <summary> 
            /// Indicates there were one or more changes to the DataTable excluding unchanged 
            /// </summary> 
            /// <returns></returns> 
            public bool Any { get; set; }
        }
    }
}
