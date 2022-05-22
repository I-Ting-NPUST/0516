using System;

namespace _0516.Models
{
    public interface IBaseData
    {
        bool isDelete { get; set; }

        DateTime creDateTime { get; set; }

        DateTime updateDateTime { get; set; }
    }
}