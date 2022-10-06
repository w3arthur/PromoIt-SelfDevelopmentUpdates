﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PromotItLibrary.Interfaces.Variables_Interfaces;
using PromotItLibrary.Models;
using PromotItLibrary.Patterns.Actions;
using PromotItLibrary.Patterns.Actions.Actions_Interfaces;

namespace PromotItLibrary.Interfaces
{
    public interface IActivistUser : IUsers, IActivistUser_Variables, IActionsUser_ActivistUser
    {

    }
}
