MonoDevelop and Visual Studio for Mac addin that tests how to use MEF inside the addin.

Requires Visual Studio for Mac 7.2 or MonoDevelop 7.2. MEF support was added in that version.

Uses [Export] to export an IFoo interface and some types that use that interface.
Then shows how to use MonoDevelop's CompositionManager to get the instances of those types
directly or have them added to another class that defines an [ImportMany] for the IFoo
interface.

    public interface IFoo
    {
    }

    [Export (typeof (IFoo))]
    public class First : IFoo
    {
    }

    [Export (typeof (IFoo))]
    public class Second : IFoo
    {
    }

    [Export]
    public class FooContainer
    {
        [ImportMany (typeof (IFoo))]
        public IEnumerable<IFoo> items;
    }

    var exportedValues = CompositionManager.Instance.ExportProvider.GetExportedValues<IFoo> ();

    var container = CompositionManager.GetExportedValue<FooContainer> ();
