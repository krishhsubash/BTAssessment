using Bogus;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Assessment.Helpers.Core
{
    public class CommonHelper
    {
        public string DynamicText { get; set; }

        public CommonHelper GenerateDynamicData([Optional] int limit)
        {
            return new Faker<CommonHelper>()
               .Rules((f, c) =>
               {
                   var lorem = new Bogus.DataSets.Lorem();
                   c.DynamicText = lorem.Sentence(limit, limit != 0 ? 0 : 8);
               }).Generate();
        }
    }
}
