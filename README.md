# NavigationGraph7
See NavigationGraph.docx.
Go to end of file

NavigationGraph7 is the first project where I’ve attempted to use Material Design 3 or just Material3 for short. I’ve basically taken the previous project NavigationGraph6 and added a couple of new fragments, WidgetsFragment and PurchaseFragment and a BottomSheetDialogFragment. The WidgetsFragment has some specific Material 3 components e.g. MaterialSwitch (it is big…) and the PurchaseFragment contains a BottomSheetDialog, containing the same text as displayed in the existing Subscription Information dialog as a comparison when using Material3. The project has been converted to Material3 by changing the theme from  Theme.MaterialComponents.* to Theme.Material3.*.

For a full description of the problems encounted - see NavigationGraph.docx and search for NavigationGraph7.

Edit: Nov 20 2022

After posting this update I found out that Animations were not working like they were in previous versions. When I started this project I made sure that I was using the latest Xamarin NuGets, because it was a Material 3 project, so I updated everything to the latest at that time. The animation problem is a result of using Xamarin.AndroidX.Navigation.Ui 2.5.2 and above. If you drop it back to 2.5.1 the Slider animations are back to what they were in NavigationGraph6. I always match Xamarin.AndroidX.Fragment.Navigation.Fragment with Navigation.Ui so I'd recommened making it 2.5.1 also.
