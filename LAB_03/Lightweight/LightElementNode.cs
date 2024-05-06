using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightweight
{
    public class LightElementNode : Composite.LightElementNode
    {
        private static Dictionary<string, LightElementNode> _flyweight = new Dictionary<string, LightElementNode>();

        private LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> childNodes)
            : base(tagName, displayType, closingType, cssClasses, childNodes)
        {

        }

        public static LightElementNode GetElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> childNodes)
        {
            string key = $"{tagName}_{displayType}_{closingType}_{string.Join(",", cssClasses)}";

            if (!_flyweight.ContainsKey(key))
            {
                _flyweight[key] = new LightElementNode(tagName, displayType, closingType, cssClasses, childNodes);
            }

            return _flyweight[key];
        }


    }

}
