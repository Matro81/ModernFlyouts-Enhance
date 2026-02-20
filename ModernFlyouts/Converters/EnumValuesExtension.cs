using System;
using System.Windows.Markup;

namespace ModernFlyouts.Converters
{
    public class EnumValuesExtension : MarkupExtension
    {
        public Type Type { get; set; }

        public EnumValuesExtension() { }
        public EnumValuesExtension(Type type)
        {
            Type = type;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Type == null) throw new InvalidOperationException("The Type property cannot be null.");
            return Enum.GetValues(Type);
        }
    }
}
