using System;

namespace ObserverClassLibrary
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }
        public List<string> CSS { get; }
        public List<LightNode> Nodes { get; }
        private Observer observer = new Observer();

        public LightElementNode(string tagName, string displayType, string closingType, List<string> css, List<LightNode> nodes)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CSS = css;
            Nodes = nodes;
        }

        public void AddEventListener(string eventType, Action listener)
        {
            observer.AddEventListener(eventType, listener);
        }

        public void TriggerEvent(string eventType)
        {
            observer.TriggerEvent(eventType);
        }

        public override string OuterHTML
        {
            get
            {
                string cssClassStr = string.Join(" ", CSS);
                string attributes = $"class=\"{cssClassStr}\"";
                string childrenHTML = string.Join("", Nodes.ConvertAll(node => node.OuterHTML));

                if (ClosingType == "selfClosing")
                    return $"<{TagName} {attributes}/>";
                else
                    return $"<{TagName} {attributes}>{childrenHTML}</{TagName}>";
            }
        }

        public override string InnerHTML
        {
            get
            {
                return string.Join("", Nodes.ConvertAll(node => node.OuterHTML));
            }
        }
    }

}
