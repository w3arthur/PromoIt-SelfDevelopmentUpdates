﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Models;
using PromotItLibrary.Patterns;
using PromotItLibrary.Patterns.Actions;
using PromotItLibrary.Patterns.DataTables;
using PromotItLibrary.Patterns.LinkedLists;
using PromotItLibrary.Patterns.LinkedLists.LinkedList_Function_State.LinkedLists_Interfaces;
using PromotItLibrary.Patterns.Actions.Actions_Interfaces;
using PromotItLibrary.Patterns.DataTables.DataTables_Interfaces;
using PromotItLibrary.Classes;
using PromotItLibrary.Interfaces.Variables_Interfaces;

namespace PromotItLibrary.Interfaces
{
    public interface IProductDonated : IProductDonated_Variables, IActionsProduct_ProductDonated, ILinkedListProduct_ProductDonated, IDataTabletProduct_ProductDonated
    {

    }
}
