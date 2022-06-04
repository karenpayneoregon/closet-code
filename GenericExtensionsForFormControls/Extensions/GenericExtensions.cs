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

        /// <summary>
        /// Hard-wired to get <see cref="BaseModel"/>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static (string text, BaseModel category) CurrentCategory(this ListControl source)
            => (source.Text, (BaseModel)source.SelectedValue);


        /// <summary>
        /// Hard-wired to get <see cref="BaseModel"/>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static (string text, BaseModel category) CurrentProduct(this ListControl source)
            => (source.Text, (BaseModel)source.SelectedValue);

        /// <summary>
        /// Generic of above
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static (string text, T item) Current<T>(this ListControl source)
            => (source.Text, (T)source.SelectedValue);

    }
}
