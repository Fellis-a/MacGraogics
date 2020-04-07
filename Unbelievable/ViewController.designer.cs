// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Unbelievable
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSClipView txtGet { get; set; }

		[Outlet]
		AppKit.NSTextField txtGett { get; set; }

		[Outlet]
		AppKit.NSTextField txtInfo { get; set; }

		[Outlet]
		AppKit.NSTextField txtQueue { get; set; }

		[Action ("btnGet:")]
		partial void btnGet (AppKit.NSButtonCell sender);

		[Action ("btnRefill:")]
		partial void btnRefill (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtGet != null) {
				txtGet.Dispose ();
				txtGet = null;
			}

			if (txtGett != null) {
				txtGett.Dispose ();
				txtGett = null;
			}

			if (txtInfo != null) {
				txtInfo.Dispose ();
				txtInfo = null;
			}

			if (txtQueue != null) {
				txtQueue.Dispose ();
				txtQueue = null;
			}
		}
	}
}
