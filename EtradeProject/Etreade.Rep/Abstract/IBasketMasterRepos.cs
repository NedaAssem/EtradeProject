﻿using Etreade.Core;
using Etreade.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Rep.Abstract
{
    public interface IBasketMasterRepos: IBaseRepos<BaskitMaster>
    {
       public int CheckOrder(string userId);
    }
}
