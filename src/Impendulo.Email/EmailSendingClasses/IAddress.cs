﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Email
{
    public interface IEmailAddress
    {
        Boolean ValidateEmailAddress(string strEmailAddress);
    }
}