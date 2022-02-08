using Microsoft.CodeAnalysis;

namespace MyTestGenerator
{
    public class MySyntaxReceiver : ISyntaxContextReceiver
    {
        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            // Do nothing here.
            // This just exists to simplify
        }
    }
}




