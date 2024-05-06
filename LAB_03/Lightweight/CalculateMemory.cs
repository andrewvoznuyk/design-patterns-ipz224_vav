using Composite;

namespace Lightweight
{
    public class CalculateMemory
    {
        public static long CalculateSize(LightNode node)
        {
            long size = 0;

            size += GC.GetTotalMemory(false);

            size += CalculateNodeSize(node);

            return size;
        }

        public static long CalculateNodeSize(LightNode node)
        {
            long size = 0;

            if (node is LightTextNode textNode)
            {
                size += sizeof(char) * textNode.OuterHTML.Length;
            }
            else if (node is LightElementNode elementNode)
            {
                size += sizeof(char) * elementNode.OuterHTML.Length;
                foreach (var child in elementNode.Children)
                {
                    size += CalculateNodeSize(child);
                }
            }

            return size;
        }

    }
}
