﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll.Library.Models;

namespace Dll.Library.Data
{
    public interface IVideoEncoder
    {
        void Encode(Video video);
    }
}