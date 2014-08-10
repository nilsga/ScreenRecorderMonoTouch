using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libScreenRecorderLib.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true, Frameworks = "CoreVideo CoreMedia QuartzCore AVFoundation")]
