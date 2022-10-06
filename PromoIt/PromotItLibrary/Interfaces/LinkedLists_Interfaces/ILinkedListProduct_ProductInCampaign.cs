﻿using MySql.Data.MySqlClient;
using PromotItLibrary.Classes;
using PromotItLibrary.Enums;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotItLibrary.Patterns.LinkedLists.LinkedList_Function_State.LinkedLists_Interfaces
{
    public interface ILinkedListProduct_ProductInCampaign
    {
        Task<List<ProductInCampaign>> MySQL_GetProductList_ListAsync(Modes mode = null);
    }
}
