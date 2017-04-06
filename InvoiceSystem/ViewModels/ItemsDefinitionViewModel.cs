﻿using InvoiceSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace InvoiceSystem.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class ItemsDefinitionViewModel : ViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        private IList<ItemViewModel> allItems;

        /// <summary>
        /// 
        /// </summary>
        public IList<ItemViewModel> AllItems { get; }


        /// <summary>
        /// 
        /// </summary>
        public ItemsDefinitionViewModel()
        {
            try
            {
                var items = SQL.LoadItems();
                AllItems = items.Select(item => new ItemViewModel(item)).ToList();
            }
            catch (Exception ex)
            {
                Error.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex);
            }
        }
    }
}
