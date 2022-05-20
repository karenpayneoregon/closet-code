using System.Collections.Generic;
using System.Linq;
using ThirdPartyLibrary.Models;

namespace ThirdPartyLibrary.Classes
{
    /// <summary>
    /// Mocked up data which would normally come from a data source such as a database, file or web service.
    /// </summary>
    public class References
    {

        /// <summary>
        /// Fully editable 
        /// </summary>
        public static List<Departments> DepartmentEditableList =
            Departments().Select(department 
                => new Departments(department.Id, department.Name)).ToList();

        /// <summary>
        /// Completely read-only
        /// </summary>
        /// <returns></returns>
        public static IReadOnlyList<Department> Departments() =>
            new List<Department>
            {
                new (1, "Admitting"),
                new (2, "Cardiology and Cardiac Surgery"),
                new (3, "Endocrinology"),
                new (4, "Accident and emergency"),
                new (5, "Anesthetics"),
                new (6, "Breast screening"),
                new (7, "Cardiology"),
                new (8, "Chaplaincy"),
                new (9, "Critical care"),
                new (10, "Diagnostic imaging"),
                new (11, "Discharge lounge"),
                new (12, "Ear nose and throat"),
                new (13, "Elderly services"),
                new (14, "Gastroenteritis"),
                new (15, "General surgery"),
                new (16, "Gynecology"),
                new (17, "Hematology"),
                new (18, "Maternity"),
                new (19, "Microbiology"),
                new (20, "Neonatal unit")
            };

        public static IReadOnlyList<Country> Countries() =>
            new List<Country>()
            {
                new(1, "Argentina"),
                new(2, "Austria"),
                new(3, "Belgium"),
                new(4, "Brazil"),
                new(5, "Canada"),
                new(6, "Denmark"),
                new(7, "Finland"),
                new(8, "France"),
                new(9, "Germany"),
                new(10, "Ireland"),
                new(11, "Italy"),
                new(12, "Mexico"),
                new(13, "Norway"),
                new(14, "Poland"),
                new(15, "Portugal"),
                new(16, "Spain"),
                new(17, "Sweden"),
                new(18, "Switzerland"),
                new(19, "UK"),
                new(20, "USA"),
                new(21, "Venezuela")
            };

        /// <summary>
        /// Read-only list of <see cref="Vendor"/>
        /// </summary>
        /// <returns></returns>
        public static IReadOnlyList<Vendor> Vendors() => new List<Vendor>()
            {
                new (0,"SELECT","Select",0),
                new (1,"ANDERSON0001","Anderson Custom Bikes",2),
                new (2,"BERGERON0001","Bergeron Off-Roads",1),
                new (3,"BICYCLE0001","Bicycle Specialists",1),
                new (4,"CAPITAL0001","Capital Road Cycles",3),
                new (5,"ELECTRON0001","Electronic Bike Co.",1)
            };
        public static IReadOnlyList<Vendor> VendorsUnSorted() => new List<Vendor>()
        {
            new (0,"SELECT","Select",0),
            new (5,"ELECTRON0001","Electronic Bike Co.",1),
            new (3,"BICYCLE0001","Bicycle Specialists",1),
            new (2,"BERGERON0001","Bergeron Off-Roads",1),
            new (1,"ANDERSON0001","Anderson Custom Bikes",2),
            new (4,"CAPITAL0001","Capital Road Cycles",3),
        };

        public static List<VendorItem> VendorItems() => new List<VendorItem>()
        {
            new () {Id = 0, AccountNumber = "SELECT", DisplayName = "Select", CreditRating = 1},
            new () {Id = 1, AccountNumber = "ANDERSON0001", DisplayName = "Anderson Custom Bikes", CreditRating = 2},
            new () {Id = 2, AccountNumber = "BERGERON0001", DisplayName = "Bergeron Off-Roads", CreditRating = 1},
            new () {Id = 3, AccountNumber = "BICYCLE0001", DisplayName = "Bicycle Specialists", CreditRating = 2},
            new () {Id = 4, AccountNumber = "CAPITAL0001", DisplayName = "Capital Road Cycles", CreditRating = 3},
            new () {Id = 5, AccountNumber = "ELECTRON0001", DisplayName = "Electronic Bike Co.", CreditRating = 1}
        };
    }
}
