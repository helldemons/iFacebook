﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public interface IField
    {
        string getName();
        string getDescription();
        string getType();
    }
}
