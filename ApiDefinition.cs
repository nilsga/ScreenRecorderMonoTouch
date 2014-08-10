using System;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace MonoTouch.ScreenRecorder {

	public delegate NSString FileNameBlock(); 

	[BaseType (typeof (NSObject))]
	public partial interface SRScreenRecorder {

		[Export ("frameInterval")]
		int FrameInterval { get; set; }

		[Export ("autosaveDuration")]
		uint AutosaveDuration { get; set; }

		[Export ("showsTouchPointer")]
		bool ShowsTouchPointer { get; set; }

		[Export ("filenameBlock")]
		FileNameBlock FilenameBlock { set; }

		[Static, Export ("sharedInstance")]
		SRScreenRecorder SharedInstance { get; }

		[Export ("startRecording")]
		void StartRecording ();

		[Export ("stopRecording")]
		void StopRecording ();
	}
}
