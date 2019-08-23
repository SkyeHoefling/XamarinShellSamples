using System;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using ShellCustomization.Controls;
using Xamarin.Forms.Platform.Android;

namespace ShellCustomization.Droid.Renderers
{
    public class MyShellItemRenderer : ShellItemRenderer
    {
        FrameLayout _shellOverlay;
        BottomNavigationView _bottomView;

        public MyShellItemRenderer(IShellContext shellContext) : base(shellContext)
        {
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var outerlayout = base.OnCreateView(inflater, container, savedInstanceState);
            _bottomView = outerlayout.FindViewById<BottomNavigationView>(Resource.Id.bottomtab_tabbar);
            _shellOverlay = outerlayout.FindViewById<FrameLayout>(Resource.Id.bottomtab_tabbar_container);

            if (ShellItem is MyTabBar myTabBar && myTabBar.LargeTab != null)
                SetupLargeTab();

            return outerlayout;
        }

        private void SetupLargeTab()
        {

        }
    }
}