using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SourcecastReportsApi.Models
{
    public enum DbSourcecastType
    {
        /// <summary>
        /// Unknown - Default value
        /// </summary>
        Unknown,

        /// <summary>
        /// VETCentral
        /// </summary>
        Vet,

        /// <summary>
        /// VOCCentral
        /// </summary>
        Voc,

    }
}