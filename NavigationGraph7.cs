using Android.App;
using Android.Runtime;
using System;

namespace com.companyname.navigationgraph7
{
    [Application]
    public class NavigationGraph7Application : Application
    {
        #region Ctor
        public NavigationGraph7Application(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
        #endregion
        public override void OnCreate()
        {
            base.OnCreate();
            // This screws up when using the SplashScreen Api - looks like an Android bug. So we use DynamicColors.ApplyToActivityIfAvailable in BaseActivity since we only have one activity. - note the singular, rather than the plural  
            //DynamicColors.ApplyToActivitiesIfAvailable(this);
        }
    }
}