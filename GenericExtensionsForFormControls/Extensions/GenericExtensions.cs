using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GenericExtensionsForFormControls.Models;

namespace GenericExtensionsForFormControls.Extensions
{
    /// <summary>
    /// First two extensions are the same except for their names
    /// The abstract class <see cref="BaseModel"/> is used to keep things
    /// simple.
    ///
    /// In a real app, <see cref="Category"/> and <see cref="Product"/> would
    /// have different property names e.g. CategoryName rather than Name and
    /// ProductName rather than Name for Product or than again may be not but
    /// there would be more properties in each class/model. So keep this in
    /// Mind when learning.
    /// </summary>
    public static class GenericExtensions
    {

        #region Common but not generic

        /// <summary>
        /// Hard-wired to get <see cref="BaseModel"/>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static (string text, BaseModel category) CurrentCategory(this ListControl source)
            => (source.Text, (BaseModel)source.SelectedValue);

        #endregion


        /// <summary>
        /// Hard-wired to get <see cref="BaseModel"/>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static (string text, BaseModel category) CurrentProduct(this ListControl source)
            => (source.Text, (BaseModel)source.SelectedValue);

        #region Generic

        /// <summary>
        /// Generic of above
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static (string text, T item) Current<T>(this ListControl source)
            => (source.Text, (T)source.SelectedValue);

        /// <summary>
        /// Get checked items as <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">Model</typeparam>
        /// <param name="sender">CheckedListBox</param>
        /// <returns>List if one or more items are checked</returns>
        public static List<T> CheckedList<T>(this CheckedListBox sender)
            => sender.Items.Cast<T>()
                .Where((item, index) => sender.GetItemChecked(index))
                .Select(item => item)
                .ToList();

        #endregion

    }
}
