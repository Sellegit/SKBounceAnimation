using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoTouch.CoreAnimation;
using MonoTouch.ObjCRuntime;

namespace SKBounceAnimationBinding {

  [BaseType (typeof (CAKeyFrameAnimation))]
	public partial interface SKBounceAnimation {

		[Export ("fromValue", ArgumentSemantic.Retain)]
    NSObject FromValue { get; set; }

		[Export ("byValue", ArgumentSemantic.Retain)]
    NSObject ByValue { get; set; }

		[Export ("toValue", ArgumentSemantic.Retain)]
    NSObject ToValue { get; set; }

		[Export ("numberOfBounces")]
		uint NumberOfBounces { get; set; }

		[Export ("shouldOvershoot")]
		bool ShouldOvershoot { get; set; }

		[Export ("shake")]
		bool Shake { get; set; }

		[Export ("stiffness")]
		float Stiffness { get; set; }

		[Static, Export ("animationWithKeyPath:")]
		SKBounceAnimation AnimationWithKeyPath (string keyPath);
	}
}
