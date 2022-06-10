using System.Collections.Generic;

namespace HW3Project.Models
{
    public class GroceryItemsModel
    {
        public IList<GroceryItemModel> AddItem(GroceryItemModel newItem, IList<GroceryItemModel> GroceryList)
        {
            GroceryList.Add(newItem);
            
            return GroceryList;
        }
    }
}