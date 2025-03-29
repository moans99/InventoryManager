using InventoryManager.Models;
using InventoryManager.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace InventoryManager.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        #region --- FIELDS ---
        private ObservableCollection<Product> _products;
        #endregion

        #region --- PROPERTIES ---
        #region --- BOUND ---
        public ObservableCollection<Product> Products
        {
            get
            {
                return _products;
            } 
            set
            {
                SetProperty(ref _products, value);
            }
        
        }
        #endregion
        #endregion

        #region --- FUNCTIONS ---
        #region --- BOUND ---
        public void InsertProduct()
        {
            var newProduct = new Product
            {
                Name = "SampleName",
                Type = "SampleType",
                AcquisitionDate = DateTime.UtcNow,
                ExpirationDate = DateTime.UtcNow,
                UnboxingDate = DateTime.UtcNow,
                PackageExpirationDate = DateTime.UtcNow,
                Price = Random.Shared.Next(),
                Stock = 1,
                Brand = "SampleBrand"
            };
            Database.InsertDocument<Product>(newProduct, "Products");
            Products.Add(newProduct);
        }
        #endregion
        #endregion



        public MainWindowViewModel()
        {
            Products  = new ObservableCollection<Product>();
            Database.Initialize();
            Database.LoadDatabase("InventoryManager");
        }




    }
}
