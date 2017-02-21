using System.Collections.Generic;
using Xunit;
using System;
using Moq;
using System.Linq;

namespace InventoryUnitTesting
{
    public class Testing
    {
        private readonly IList<Product> _productList;
        private readonly IList<Cart> _cartList;
        private readonly IList<Inventory> _inventoryList;
        private int Quantity;

        //ADD product to the inventry

        [Fact]
        public void WhenAddingProductToInventory_InventoryListShouldbeIncreased()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id=6,
                ProductId =5,
                Quantity =5,

            };

            var prgm = new Program();
            var list = prgm.AddInventory(inventory);
            Assert.Equal(list.Count, db.InventoryList.Count);
        }

        //Delete product

        [Fact]
        public void WhenDeletingProductdetailsfromInventory_InventoryListShouldbeDecreased()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id=4,
                ProductId = 4,
                Quantity =50 ,

            };

            var prgm = new Program();
            var list = prgm.DeleteInventory(inventory);
            Assert.NotEqual(list.Count, db.InventoryList.Count);
        }

        //update product
      
        [Fact]
        public void WhenUpdatingProductDetailsInInventory_InventoryListShouldbeUpdated()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 3,
                ProductId = 5,
                Quantity = 10,
                Price=100,

            };

            var prgm = new Program();
            var list = prgm.UpdateInventory(inventory);
            Assert.Equal(3, db.InventoryList.Count);
        }
        //check product exit or not
        [Fact]
        public void WhencheckProductExistOrNot()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                ProductId = 5,
            };
            var prgm = new Program();
            var ans = "1";
            var list = prgm.CheckProductIsExistInInventoryOrNot();
            Assert.Same(ans,db.InventoryList.Contains(inventory));
        }

        //checkout product

        [Fact]
        public void WhenCheckOutFromCart_InventoryWillUpdate()
        {
            var db = new Database();
            var cart=new Cart()
            {
                Id=2,
                ProductId = 2,
                OrderedQuantity = 10
            };
            var prgm = new Program();
            var list = prgm.CheckOutTheCartandUpdateInventory();
            Assert.Equal(3, db.CartList.Count);

            var inventoryupdate = new Inventory()
            {
                Id=2,
                ProductId = 2,
                Quantity =10
            };
            var list2 = prgm.UpdateInventory(inventoryupdate);
            var ans = "1";
            Assert.Same(ans, db.InventoryList.Contains(inventoryupdate));
        }
    }
}
