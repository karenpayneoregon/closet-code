using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikSampleApp.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace TelerikSampleApp.Controllers
{
    /// <summary>
    /// Karen notes
    /// - There are two different ways for connecting to the database.
    ///   Originally all connection were done one at a time which is correct,
    ///   the method <see cref="GetContactsAsync"/> uses a static instance which is not recommended,
    ///   shown here for not what to do.
    /// </summary>
    public class GridController : Controller
    {
        private static NorthWind2020Context _northWind2020Context;
        public GridController(NorthWind2020Context context)
        {
            _northWind2020Context = context;
        }


        public static async Task<List<ContactItem>> GetContactsAsync()
        {
            
            return await Task.Run(async () =>
            {
                // KP recommended
                //await using var context =  new NorthWind2020Context();
                
                // not recommended
                return await _northWind2020Context.Contacts
                    .AsNoTracking()
                    .Include(contact => contact.ContactTypeIdentifierNavigation)
                    .Include(c => c.ContactDevices)
                    .ThenInclude(contactDevices => contactDevices.PhoneTypeIdentifierNavigation)
                    .Select(contact => new ContactItem
                    {
                        Id = contact.ContactId,
                        ContactName = contact.FirstName + " " + contact.LastName,
                        ContactType = contact.ContactTypeIdentifierNavigation.ContactTitle,
                        OfficePhone = contact.ContactDevices.FirstOrDefault(contactDevices => contactDevices.PhoneTypeIdentifier == 3).PhoneNumber ?? "(none)",
                        CellPhone = contact.ContactDevices.FirstOrDefault(contactDevices => contactDevices.PhoneTypeIdentifier == 2).PhoneNumber ?? "(none)",
                        HomePhone = contact.ContactDevices.FirstOrDefault(contactDevices => contactDevices.PhoneTypeIdentifier == 1).PhoneNumber ?? "(none)"
                    }).ToListAsync();
            });
        }

        public async Task<ActionResult> Contacts_Read([DataSourceRequest] DataSourceRequest request)
        {
            var dsResult = await GetContactsAsync();
            return Json(await dsResult.ToDataSourceResultAsync(request));
        }

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            using var context = new NorthWind2020Context();
            return Json(context.Products.ToDataSourceResult(request));
        }

        public ActionResult Products_Create([DataSourceRequest] DataSourceRequest request, Product product)
        {
            using var context = new NorthWind2020Context();
            context.Products.Add(product);
            context.SaveChanges();

            return Json(new[] { product }.ToDataSourceResult(request));
        }

        public ActionResult Products_Destroy([DataSourceRequest] DataSourceRequest request, Product product)
        {
            using var context = new NorthWind2020Context();
            context.Products.Remove(product);
            context.SaveChanges();

            return Json(new[] { product }.ToDataSourceResult(request));
        }

        public ActionResult Products_Update([DataSourceRequest] DataSourceRequest request, Product product)
        {
            using var context = new NorthWind2020Context();
            context.Products.Update(product);
            context.SaveChanges();

            return Json(new[] { product }.ToDataSourceResult(request));
        }
    }
}
