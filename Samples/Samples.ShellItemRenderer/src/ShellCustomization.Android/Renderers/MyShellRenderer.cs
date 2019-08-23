using Android.Content;
using ShellCustomization.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Shell), typeof(MyShellRenderer))]
namespace ShellCustomization.Droid.Renderers
{
    public class MyShellRenderer : ShellRenderer
    {
        public MyShellRenderer(Context context) : base(context)
        {
        }

        protected override IShellItemRenderer CreateShellItemRenderer(ShellItem shellItem)
        {
            return new MyShellItemRenderer(this);
        }
    }
}