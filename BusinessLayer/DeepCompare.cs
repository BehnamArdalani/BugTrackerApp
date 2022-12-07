using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class DeepCompare
    {
        public static List<Variance> CompareTwoObjects<T>(this T value1, T value2)
        {
            List<Variance> result = new List<Variance>();
            FieldInfo[] filds = value1.GetType().GetFields();
            foreach (FieldInfo field in filds)
            {
                Variance v = new Variance();
                v.Prop = field.Name;
                v.Value1 = field.GetValue(value1)!;
                v.Value2 = field.GetValue(value2)!;
                if(!Equals(v.Value1, v.Value2))
                    result.Add(v);

            }

            return result;
        }
    }

    public class Variance
    {
        public string Prop { get; set; }
        public object Value1 { get; set; }
        public object Value2 { get; set; }
    }
}
