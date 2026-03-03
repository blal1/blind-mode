using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x200040E")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal interface IStylePropertyAnimationSystem
{
	[Token(Token = "0x6001E7E")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E7F")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E80")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E81")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E82")]
	bool StartTransitionEnum(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E83")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E84")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E85")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E86")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E87")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E88")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E89")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E8A")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E8B")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E8C")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E8D")]
	bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

	[Token(Token = "0x6001E8E")]
	void CancelAllAnimations();

	[Token(Token = "0x6001E8F")]
	void CancelAllAnimations(VisualElement owner);

	[Token(Token = "0x6001E90")]
	void CancelAnimation(VisualElement owner, StylePropertyId id);

	[Token(Token = "0x6001E91")]
	void UpdateAnimation(VisualElement owner, StylePropertyId id);

	[Token(Token = "0x6001E92")]
	void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds);

	[Token(Token = "0x6001E93")]
	void Update();
}
