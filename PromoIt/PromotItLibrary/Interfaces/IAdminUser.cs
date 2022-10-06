﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using PromotItLibrary.Interfaces.Variables_Interfaces;
using PromotItLibrary.Models;
using PromotItLibrary.Patterns;
using PromotItLibrary.Patterns.Actions;
using PromotItLibrary.Patterns.LinkedLists;
using PromotItLibrary.Patterns.LinkedLists.DataTables_Interfaces;
using PromotItLibrary.Patterns.LinkedLists.LinkedList_Function_State.LinkedLists_Interfaces;

namespace PromotItLibrary.Interfaces
{
    public interface IAdminUser : IUsers, IAdminUser_Variables, ILinkeListUser_Admin, IDataTableUser_Admin
    {

    }
}
