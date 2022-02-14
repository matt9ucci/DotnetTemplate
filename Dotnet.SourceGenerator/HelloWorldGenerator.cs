namespace Dotnet.SourceGenerator;

[Generator]
public class HelloWorldGenerator : ISourceGenerator {
	public void Execute(GeneratorExecutionContext context) {
		StringBuilder sb = new();
		sb.AppendLine("Console.WriteLine(\"Hello, Source Generator!\");");
		context.AddSource("HelloWorldGenerated.g.cs", SourceText.From(sb.ToString(), Encoding.UTF8));
	}

	public void Initialize(GeneratorInitializationContext context) { }
}
