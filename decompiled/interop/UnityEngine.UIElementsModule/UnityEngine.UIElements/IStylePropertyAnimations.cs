using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x200040D")]
internal interface IStylePropertyAnimations
{
	[Token(Token = "0x17000862")]
	int runningAnimationCount
	{
		[Token(Token = "0x6001E7A")]
		get;
		[Token(Token = "0x6001E7B")]
		set;
	}

	[Token(Token = "0x17000863")]
	int completedAnimationCount
	{
		[Token(Token = "0x6001E7C")]
		get;
		[Token(Token = "0x6001E7D")]
		set;
	}

	[Token(Token = "0x6001E66")]
	bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E67")]
	bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E68")]
	bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E69")]
	bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E6A")]
	bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E6B")]
	bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E6C")]
	bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E6D")]
	bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E6E")]
	bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E6F")]
	bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E70")]
	bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E71")]
	bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E72")]
	bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E73")]
	bool Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E74")]
	bool Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E75")]
	bool Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<float, float> easingCurve);

	[Token(Token = "0x6001E76")]
	void UpdateAnimation(StylePropertyId id);

	[Token(Token = "0x6001E77")]
	void GetAllAnimations(List<StylePropertyId> outPropertyIds);

	[Token(Token = "0x6001E78")]
	void CancelAnimation(StylePropertyId id);

	[Token(Token = "0x6001E79")]
	void CancelAllAnimations();
}
