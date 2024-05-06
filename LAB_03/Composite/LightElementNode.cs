using System.Text;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses;
            Children = children;
        }

        public override string OuterHTML
        {
            get
            {
                StringBuilder html = new StringBuilder();
                html.Append($"<{TagName}");

                if (CssClasses.Count > 0)
                {
                    html.Append($" class=\"{string.Join(" ", CssClasses)}\"");
                }

                html.Append(">");

                foreach (var child in Children)
                {
                    html.Append(child.OuterHTML);
                }

                if (ClosingType == "double")
                {
                    html.Append($"</{TagName}>");
                }
                else if (ClosingType == "single")
                {
                    html.Append("/>");
                }

                return html.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder html = new StringBuilder();

                foreach (var child in Children)
                {
                    html.Append(child.OuterHTML);
                }

                return html.ToString();
            }
        }
    }
}
