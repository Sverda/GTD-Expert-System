using System;
using System.ComponentModel;
using GtdExpertSystem.Models;

namespace GtdExpertSystem.BussinesLogic
{
    internal static class ResultsExtensions
    {
        internal static string GetDescription(this Results result)
        {
            Type type = result.GetType();
            var memInfo = type.GetMember(result.ToString());

            if (memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return result.ToString();
        }
    }
}
