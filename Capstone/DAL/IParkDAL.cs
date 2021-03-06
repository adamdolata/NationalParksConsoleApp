﻿using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.DAL
{
    public interface IParkDAL
    {
        IList<Park> GetParks();
        Park GetParkById(int parkId);
    }
}
