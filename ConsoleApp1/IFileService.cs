﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Logic
{
    public interface IFileService
    {
        void LoadDataFromFile();
        void SaveDataToFile();
    }
}
