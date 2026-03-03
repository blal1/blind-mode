using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine.Bindings;
using UnityEngine.Pool;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x200040F")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem
{
	[Token(Token = "0x2000410")]
	[Flags]
	private enum TransitionState
	{
		[Token(Token = "0x4000D68")]
		None = 0,
		[Token(Token = "0x4000D69")]
		Running = 1,
		[Token(Token = "0x4000D6A")]
		Started = 2,
		[Token(Token = "0x4000D6B")]
		Ended = 4,
		[Token(Token = "0x4000D6C")]
		Canceled = 8
	}

	[Token(Token = "0x2000411")]
	private struct AnimationDataSet<TTimingData, TStyleData>
	{
		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0x0")]
		public VisualElement[] elements;

		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0x0")]
		public StylePropertyId[] properties;

		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0x0")]
		public TTimingData[] timing;

		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0x0")]
		public TStyleData[] style;

		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x0")]
		public int count;

		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<ElementPropertyPair, int> indices;

		[Token(Token = "0x17000864")]
		private int capacity
		{
			[Token(Token = "0x6001EAF")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001EB0")]
			set
			{
			}
		}

		[Token(Token = "0x6001EB1")]
		private void LocalInit()
		{
		}

		[Token(Token = "0x6001EB2")]
		public static AnimationDataSet<TTimingData, TStyleData> Create()
		{
			return default(AnimationDataSet<TTimingData, TStyleData>);
		}

		[Token(Token = "0x6001EB3")]
		public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EB4")]
		public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData)
		{
		}

		[Token(Token = "0x6001EB5")]
		public void Remove(int cancelledIndex)
		{
		}

		[Token(Token = "0x6001EB6")]
		public void Replace(int index, TTimingData timingData, TStyleData styleData)
		{
		}

		[Token(Token = "0x6001EB7")]
		public void RemoveAll(VisualElement ve)
		{
		}

		[Token(Token = "0x6001EB8")]
		public void RemoveAll()
		{
		}

		[Token(Token = "0x6001EB9")]
		public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties)
		{
		}
	}

	[Token(Token = "0x2000412")]
	private struct ElementPropertyPair
	{
		[Token(Token = "0x2000413")]
		private class EqualityComparer : IEqualityComparer<ElementPropertyPair>
		{
			[Token(Token = "0x6001EBC")]
			[Address(RVA = "0x29DB2E0", Offset = "0x29DA4E0", VA = "0x1829DB2E0", Slot = "4")]
			public bool Equals(ElementPropertyPair x, ElementPropertyPair y)
			{
				return default(bool);
			}

			[Token(Token = "0x6001EBD")]
			[Address(RVA = "0x29DB300", Offset = "0x29DA500", VA = "0x1829DB300", Slot = "5")]
			public int GetHashCode(ElementPropertyPair obj)
			{
				return default(int);
			}

			[Token(Token = "0x6001EBE")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public EqualityComparer()
			{
			}
		}

		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IEqualityComparer<ElementPropertyPair> Comparer;

		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x0")]
		public readonly VisualElement element;

		[Token(Token = "0x4000D75")]
		[FieldOffset(Offset = "0x8")]
		public readonly StylePropertyId property;

		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x14F4B00", Offset = "0x14F3D00", VA = "0x1814F4B00")]
		public ElementPropertyPair(VisualElement element, StylePropertyId property)
		{
		}
	}

	[Token(Token = "0x2000414")]
	private abstract class Values
	{
		[Token(Token = "0x6001EBF")]
		public abstract void CancelAllAnimations();

		[Token(Token = "0x6001EC0")]
		public abstract void CancelAllAnimations(VisualElement ve);

		[Token(Token = "0x6001EC1")]
		public abstract void CancelAnimation(VisualElement ve, StylePropertyId id);

		[Token(Token = "0x6001EC2")]
		public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id);

		[Token(Token = "0x6001EC3")]
		public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds);

		[Token(Token = "0x6001EC4")]
		public abstract void Update(long currentTimeMs);

		[Token(Token = "0x6001EC5")]
		protected abstract void UpdateValues();

		[Token(Token = "0x6001EC6")]
		protected abstract void UpdateComputedStyle();

		[Token(Token = "0x6001EC7")]
		protected abstract void UpdateComputedStyle(int i);

		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		protected Values()
		{
		}
	}

	[Token(Token = "0x2000415")]
	private abstract class Values<T> : Values
	{
		[Token(Token = "0x2000416")]
		private class TransitionEventsFrameState
		{
			[Token(Token = "0x4000D7B")]
			[FieldOffset(Offset = "0x0")]
			private static readonly UnityEngine.Pool.ObjectPool<Queue<EventBase>> k_EventQueuePool;

			[Token(Token = "0x4000D7C")]
			[FieldOffset(Offset = "0x0")]
			public readonly Dictionary<ElementPropertyPair, TransitionState> elementPropertyStateDelta;

			[Token(Token = "0x4000D7D")]
			[FieldOffset(Offset = "0x0")]
			public readonly Dictionary<ElementPropertyPair, Queue<EventBase>> elementPropertyQueuedEvents;

			[Token(Token = "0x4000D7E")]
			[FieldOffset(Offset = "0x0")]
			public IPanel panel;

			[Token(Token = "0x4000D7F")]
			[FieldOffset(Offset = "0x0")]
			private int m_ChangesCount;

			[Token(Token = "0x6001EE2")]
			public static Queue<EventBase> GetPooledQueue()
			{
				return null;
			}

			[Token(Token = "0x6001EE3")]
			public void RegisterChange()
			{
			}

			[Token(Token = "0x6001EE4")]
			public void UnregisterChange()
			{
			}

			[Token(Token = "0x6001EE5")]
			public bool StateChanged()
			{
				return default(bool);
			}

			[Token(Token = "0x6001EE6")]
			public void Clear()
			{
			}

			[Token(Token = "0x6001EE7")]
			public TransitionEventsFrameState()
			{
			}
		}

		[Token(Token = "0x2000418")]
		public struct TimingData
		{
			[Token(Token = "0x4000D81")]
			[FieldOffset(Offset = "0x0")]
			public long startTimeMs;

			[Token(Token = "0x4000D82")]
			[FieldOffset(Offset = "0x0")]
			public int durationMs;

			[Token(Token = "0x4000D83")]
			[FieldOffset(Offset = "0x0")]
			public Func<float, float> easingCurve;

			[Token(Token = "0x4000D84")]
			[FieldOffset(Offset = "0x0")]
			public float easedProgress;

			[Token(Token = "0x4000D85")]
			[FieldOffset(Offset = "0x0")]
			public float reversingShorteningFactor;

			[Token(Token = "0x4000D86")]
			[FieldOffset(Offset = "0x0")]
			public bool isStarted;

			[Token(Token = "0x4000D87")]
			[FieldOffset(Offset = "0x0")]
			public int delayMs;
		}

		[Token(Token = "0x2000419")]
		public struct StyleData
		{
			[Token(Token = "0x4000D88")]
			[FieldOffset(Offset = "0x0")]
			public T startValue;

			[Token(Token = "0x4000D89")]
			[FieldOffset(Offset = "0x0")]
			public T endValue;

			[Token(Token = "0x4000D8A")]
			[FieldOffset(Offset = "0x0")]
			public T reversingAdjustedStartValue;

			[Token(Token = "0x4000D8B")]
			[FieldOffset(Offset = "0x0")]
			public T currentValue;
		}

		[Token(Token = "0x200041A")]
		public struct EmptyData
		{
			[Token(Token = "0x4000D8C")]
			[FieldOffset(Offset = "0x0")]
			public static EmptyData Default;
		}

		[Token(Token = "0x4000D76")]
		[FieldOffset(Offset = "0x0")]
		private long m_CurrentTimeMs;

		[Token(Token = "0x4000D77")]
		[FieldOffset(Offset = "0x0")]
		private TransitionEventsFrameState m_CurrentFrameEventsState;

		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x0")]
		private TransitionEventsFrameState m_NextFrameEventsState;

		[Token(Token = "0x4000D79")]
		[FieldOffset(Offset = "0x0")]
		public AnimationDataSet<TimingData, StyleData> running;

		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x0")]
		public AnimationDataSet<EmptyData, T> completed;

		[Token(Token = "0x17000865")]
		public bool isEmpty
		{
			[Token(Token = "0x6001EC9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000866")]
		public abstract Func<T, T, bool> SameFunc
		{
			[Token(Token = "0x6001ECA")]
			get;
		}

		[Token(Token = "0x6001ECB")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref T a, ref T b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001ECC")]
		protected Values()
		{
		}

		[Token(Token = "0x6001ECD")]
		private void SwapFrameStates()
		{
		}

		[Token(Token = "0x6001ECE")]
		private void QueueEvent(EventBase evt, ElementPropertyPair epp)
		{
		}

		[Token(Token = "0x6001ECF")]
		private void ClearEventQueue(ElementPropertyPair epp)
		{
		}

		[Token(Token = "0x6001ED0")]
		private void QueueTransitionRunEvent(VisualElement ve, int runningIndex)
		{
		}

		[Token(Token = "0x6001ED1")]
		private void QueueTransitionStartEvent(VisualElement ve, int runningIndex)
		{
		}

		[Token(Token = "0x6001ED2")]
		private void QueueTransitionEndEvent(VisualElement ve, int runningIndex)
		{
		}

		[Token(Token = "0x6001ED3")]
		private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs)
		{
		}

		[Token(Token = "0x6001ED4")]
		private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs)
		{
		}

		[Token(Token = "0x6001ED5")]
		public sealed override void CancelAllAnimations()
		{
		}

		[Token(Token = "0x6001ED6")]
		public sealed override void CancelAllAnimations(VisualElement ve)
		{
		}

		[Token(Token = "0x6001ED7")]
		public sealed override void CancelAnimation(VisualElement ve, StylePropertyId id)
		{
		}

		[Token(Token = "0x6001ED8")]
		public sealed override void UpdateAnimation(VisualElement ve, StylePropertyId id)
		{
		}

		[Token(Token = "0x6001ED9")]
		public sealed override void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds)
		{
		}

		[Token(Token = "0x6001EDA")]
		private float ComputeReversingShorteningFactor(int oldIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6001EDB")]
		private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor)
		{
			return default(int);
		}

		[Token(Token = "0x6001EDC")]
		private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor)
		{
			return default(int);
		}

		[Token(Token = "0x6001EDD")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, long currentTimeMs)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EDE")]
		private void ForceComputedStyleEndValue(int runningIndex)
		{
		}

		[Token(Token = "0x6001EDF")]
		public sealed override void Update(long currentTimeMs)
		{
		}

		[Token(Token = "0x6001EE0")]
		private void ProcessEventQueue()
		{
		}

		[Token(Token = "0x6001EE1")]
		private void UpdateProgress(long currentTimeMs)
		{
		}
	}

	[Token(Token = "0x200041B")]
	private class ValuesFloat : Values<float>
	{
		[Token(Token = "0x17000867")]
		public override Func<float, float, bool> SameFunc
		{
			[Token(Token = "0x6001EED")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0x29F0F00", Offset = "0x29F0100", VA = "0x1829F0F00")]
		private static bool IsSame(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0x27F7B70", Offset = "0x27F6D70", VA = "0x1827F7B70")]
		private static float Lerp(float a, float b, float t)
		{
			return default(float);
		}

		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0x29F10B0", Offset = "0x29F02B0", VA = "0x1829F10B0", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x29F0F10", Offset = "0x29F0110", VA = "0x1829F0F10", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x29F1010", Offset = "0x29F0210", VA = "0x1829F1010", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x29F1140", Offset = "0x29F0340", VA = "0x1829F1140")]
		public ValuesFloat()
		{
		}
	}

	[Token(Token = "0x200041C")]
	private class ValuesInt : Values<int>
	{
		[Token(Token = "0x17000868")]
		public override Func<int, int, bool> SameFunc
		{
			[Token(Token = "0x6001EF4")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001EF5")]
		[Address(RVA = "0xC21290", Offset = "0xC20490", VA = "0x180C21290")]
		private static bool IsSame(int a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x29F15C0", Offset = "0x29F07C0", VA = "0x1829F15C0")]
		private static int Lerp(int a, int b, float t)
		{
			return default(int);
		}

		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x29F16D0", Offset = "0x29F08D0", VA = "0x1829F16D0", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x29F0DC0", Offset = "0x29EFFC0", VA = "0x1829F0DC0", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x29F0D20", Offset = "0x29EFF20", VA = "0x1829F0D20", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001EFA")]
		[Address(RVA = "0x29F18B0", Offset = "0x29F0AB0", VA = "0x1829F18B0")]
		public ValuesInt()
		{
		}
	}

	[Token(Token = "0x200041D")]
	private class ValuesLength : Values<Length>
	{
		[Token(Token = "0x17000869")]
		public override Func<Length, Length, bool> SameFunc
		{
			[Token(Token = "0x6001EFB")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x29F1990", Offset = "0x29F0B90", VA = "0x1829F1990")]
		private static bool IsSame(Length a, Length b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x29F1950", Offset = "0x29F0B50", VA = "0x1829F1950", Slot = "14")]
		protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x29F19D0", Offset = "0x29F0BD0", VA = "0x1829F19D0")]
		internal static Length Lerp(Length a, Length b, float t)
		{
			return default(Length);
		}

		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0x29F1BD0", Offset = "0x29F0DD0", VA = "0x1829F1BD0", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x29F1A30", Offset = "0x29F0C30", VA = "0x1829F1A30", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x29F1B30", Offset = "0x29F0D30", VA = "0x1829F1B30", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x29F1CC0", Offset = "0x29F0EC0", VA = "0x1829F1CC0")]
		public ValuesLength()
		{
		}
	}

	[Token(Token = "0x200041E")]
	private class ValuesColor : Values<Color>
	{
		[Token(Token = "0x1700086A")]
		public override Func<Color, Color, bool> SameFunc
		{
			[Token(Token = "0x6001F03")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x29F0880", Offset = "0x29EFA80", VA = "0x1829F0880")]
		private static bool IsSame(Color c, Color d)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F05")]
		[Address(RVA = "0x29F0900", Offset = "0x29EFB00", VA = "0x1829F0900")]
		private static Color Lerp(Color a, Color b, float t)
		{
			return default(Color);
		}

		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x29F0B60", Offset = "0x29EFD60", VA = "0x1829F0B60", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x29F0A50", Offset = "0x29EFC50", VA = "0x1829F0A50", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F08")]
		[Address(RVA = "0x29F09A0", Offset = "0x29EFBA0", VA = "0x1829F09A0", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F09")]
		[Address(RVA = "0x29F0C80", Offset = "0x29EFE80", VA = "0x1829F0C80")]
		public ValuesColor()
		{
		}
	}

	[Token(Token = "0x200041F")]
	private abstract class ValuesDiscrete<T> : Values<T>
	{
		[Token(Token = "0x1700086B")]
		public override Func<T, T, bool> SameFunc
		{
			[Token(Token = "0x6001F0A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F0B")]
		private static bool IsSame(T a, T b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F0C")]
		private static T Lerp(T a, T b, float t)
		{
			return (T)null;
		}

		[Token(Token = "0x6001F0D")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001F0E")]
		protected ValuesDiscrete()
		{
		}
	}

	[Token(Token = "0x2000420")]
	private class ValuesEnum : ValuesDiscrete<int>
	{
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x29F0DC0", Offset = "0x29EFFC0", VA = "0x1829F0DC0", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x29F0D20", Offset = "0x29EFF20", VA = "0x1829F0D20", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x29F0EC0", Offset = "0x29F00C0", VA = "0x1829F0EC0")]
		public ValuesEnum()
		{
		}
	}

	[Token(Token = "0x2000421")]
	private class ValuesBackground : ValuesDiscrete<Background>
	{
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x29F0710", Offset = "0x29EF910", VA = "0x1829F0710", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x29F0650", Offset = "0x29EF850", VA = "0x1829F0650", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x29F0840", Offset = "0x29EFA40", VA = "0x1829F0840")]
		public ValuesBackground()
		{
		}
	}

	[Token(Token = "0x2000422")]
	private class ValuesFontDefinition : ValuesDiscrete<FontDefinition>
	{
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0x29F1290", Offset = "0x29F0490", VA = "0x1829F1290", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x29F11E0", Offset = "0x29F03E0", VA = "0x1829F11E0", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x29F13A0", Offset = "0x29F05A0", VA = "0x1829F13A0")]
		public ValuesFontDefinition()
		{
		}
	}

	[Token(Token = "0x2000423")]
	private class ValuesFont : ValuesDiscrete<Font>
	{
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x29F1480", Offset = "0x29F0680", VA = "0x1829F1480", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x29F13E0", Offset = "0x29F05E0", VA = "0x1829F13E0", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x29F1580", Offset = "0x29F0780", VA = "0x1829F1580")]
		public ValuesFont()
		{
		}
	}

	[Token(Token = "0x2000424")]
	private class ValuesTextShadow : Values<TextShadow>
	{
		[Token(Token = "0x1700086C")]
		public override Func<TextShadow, TextShadow, bool> SameFunc
		{
			[Token(Token = "0x6001F1B")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x29F1D60", Offset = "0x29F0F60", VA = "0x1829F1D60")]
		private static bool IsSame(TextShadow a, TextShadow b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x29F1DB0", Offset = "0x29F0FB0", VA = "0x1829F1DB0")]
		private static TextShadow Lerp(TextShadow a, TextShadow b, float t)
		{
			return default(TextShadow);
		}

		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x29F2050", Offset = "0x29F1250", VA = "0x1829F2050", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x29F1F10", Offset = "0x29F1110", VA = "0x1829F1F10", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x29F1E40", Offset = "0x29F1040", VA = "0x1829F1E40", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x29F2190", Offset = "0x29F1390", VA = "0x1829F2190")]
		public ValuesTextShadow()
		{
		}
	}

	[Token(Token = "0x2000425")]
	private class ValuesScale : Values<Scale>
	{
		[Token(Token = "0x1700086D")]
		public override Func<Scale, Scale, bool> SameFunc
		{
			[Token(Token = "0x6001F22")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x2A087F0", Offset = "0x2A079F0", VA = "0x182A087F0")]
		private static bool IsSame(Scale a, Scale b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x2A08950", Offset = "0x2A07B50", VA = "0x182A08950", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x2A088A0", Offset = "0x2A07AA0", VA = "0x182A088A0", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x2A08820", Offset = "0x2A07A20", VA = "0x182A08820")]
		private static Scale Lerp(Scale a, Scale b, float t)
		{
			return default(Scale);
		}

		[Token(Token = "0x6001F27")]
		[Address(RVA = "0x2A08A60", Offset = "0x2A07C60", VA = "0x182A08A60", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x2A08B90", Offset = "0x2A07D90", VA = "0x182A08B90")]
		public ValuesScale()
		{
		}
	}

	[Token(Token = "0x2000426")]
	private class ValuesRotate : Values<Rotate>
	{
		[Token(Token = "0x1700086E")]
		public override Func<Rotate, Rotate, bool> SameFunc
		{
			[Token(Token = "0x6001F29")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0x2A08310", Offset = "0x2A07510", VA = "0x182A08310")]
		private static bool IsSame(Rotate a, Rotate b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0x2A084B0", Offset = "0x2A076B0", VA = "0x182A084B0", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0x2A083F0", Offset = "0x2A075F0", VA = "0x182A083F0", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x2A08360", Offset = "0x2A07560", VA = "0x182A08360")]
		private static Rotate Lerp(Rotate a, Rotate b, float t)
		{
			return default(Rotate);
		}

		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x2A085E0", Offset = "0x2A077E0", VA = "0x182A085E0", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x2A08750", Offset = "0x2A07950", VA = "0x182A08750")]
		public ValuesRotate()
		{
		}
	}

	[Token(Token = "0x2000427")]
	private class ValuesTranslate : Values<Translate>
	{
		[Token(Token = "0x1700086F")]
		public override Func<Translate, Translate, bool> SameFunc
		{
			[Token(Token = "0x6001F30")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x2A091F0", Offset = "0x2A083F0", VA = "0x182A091F0")]
		private static bool IsSame(Translate a, Translate b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x2A091C0", Offset = "0x2A083C0", VA = "0x182A091C0", Slot = "14")]
		protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x2A093C0", Offset = "0x2A085C0", VA = "0x182A093C0", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x2A09300", Offset = "0x2A08500", VA = "0x182A09300", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F35")]
		[Address(RVA = "0x2A09240", Offset = "0x2A08440", VA = "0x182A09240")]
		private static Translate Lerp(Translate a, Translate b, float t)
		{
			return default(Translate);
		}

		[Token(Token = "0x6001F36")]
		[Address(RVA = "0x2A094F0", Offset = "0x2A086F0", VA = "0x182A094F0", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001F37")]
		[Address(RVA = "0x2A096C0", Offset = "0x2A088C0", VA = "0x182A096C0")]
		public ValuesTranslate()
		{
		}
	}

	[Token(Token = "0x2000428")]
	private class ValuesTransformOrigin : Values<TransformOrigin>
	{
		[Token(Token = "0x17000870")]
		public override Func<TransformOrigin, TransformOrigin, bool> SameFunc
		{
			[Token(Token = "0x6001F38")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F39")]
		[Address(RVA = "0x2A08C60", Offset = "0x2A07E60", VA = "0x182A08C60")]
		private static bool IsSame(TransformOrigin a, TransformOrigin b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x2A08C30", Offset = "0x2A07E30", VA = "0x182A08C30", Slot = "14")]
		protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F3B")]
		[Address(RVA = "0x2A08E20", Offset = "0x2A08020", VA = "0x182A08E20", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F3C")]
		[Address(RVA = "0x2A08D60", Offset = "0x2A07F60", VA = "0x182A08D60", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F3D")]
		[Address(RVA = "0x2A08CA0", Offset = "0x2A07EA0", VA = "0x182A08CA0")]
		private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t)
		{
			return default(TransformOrigin);
		}

		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0x2A08F50", Offset = "0x2A08150", VA = "0x182A08F50", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001F3F")]
		[Address(RVA = "0x2A09120", Offset = "0x2A08320", VA = "0x182A09120")]
		public ValuesTransformOrigin()
		{
		}
	}

	[Token(Token = "0x2000429")]
	private class ValuesBackgroundPosition : ValuesDiscrete<BackgroundPosition>
	{
		[Token(Token = "0x6001F40")]
		[Address(RVA = "0x2A079A0", Offset = "0x2A06BA0", VA = "0x182A079A0", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F41")]
		[Address(RVA = "0x2A07AC0", Offset = "0x2A06CC0", VA = "0x182A07AC0", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F42")]
		[Address(RVA = "0x2A07B80", Offset = "0x2A06D80", VA = "0x182A07B80")]
		public ValuesBackgroundPosition()
		{
		}
	}

	[Token(Token = "0x200042A")]
	private class ValuesBackgroundRepeat : ValuesDiscrete<BackgroundRepeat>
	{
		[Token(Token = "0x6001F43")]
		[Address(RVA = "0x2A07C60", Offset = "0x2A06E60", VA = "0x182A07C60", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F44")]
		[Address(RVA = "0x2A07BC0", Offset = "0x2A06DC0", VA = "0x182A07BC0", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F45")]
		[Address(RVA = "0x2A07D60", Offset = "0x2A06F60", VA = "0x182A07D60")]
		public ValuesBackgroundRepeat()
		{
		}
	}

	[Token(Token = "0x200042B")]
	private class ValuesBackgroundSize : Values<BackgroundSize>
	{
		[Token(Token = "0x17000871")]
		public override Func<BackgroundSize, BackgroundSize, bool> SameFunc
		{
			[Token(Token = "0x6001F46")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F47")]
		[Address(RVA = "0x2A07DD0", Offset = "0x2A06FD0", VA = "0x182A07DD0")]
		private static bool IsSame(BackgroundSize a, BackgroundSize b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F48")]
		[Address(RVA = "0x2A07DA0", Offset = "0x2A06FA0", VA = "0x182A07DA0", Slot = "14")]
		protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref BackgroundSize a, ref BackgroundSize b)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F49")]
		[Address(RVA = "0x2A07F90", Offset = "0x2A07190", VA = "0x182A07F90", Slot = "11")]
		protected sealed override void UpdateComputedStyle()
		{
		}

		[Token(Token = "0x6001F4A")]
		[Address(RVA = "0x2A07ED0", Offset = "0x2A070D0", VA = "0x182A07ED0", Slot = "12")]
		protected sealed override void UpdateComputedStyle(int i)
		{
		}

		[Token(Token = "0x6001F4B")]
		[Address(RVA = "0x2A07E10", Offset = "0x2A07010", VA = "0x182A07E10")]
		private static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t)
		{
			return default(BackgroundSize);
		}

		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0x2A080C0", Offset = "0x2A072C0", VA = "0x182A080C0", Slot = "10")]
		protected sealed override void UpdateValues()
		{
		}

		[Token(Token = "0x6001F4D")]
		[Address(RVA = "0x2A08270", Offset = "0x2A07470", VA = "0x182A08270")]
		public ValuesBackgroundSize()
		{
		}
	}

	[Token(Token = "0x4000D54")]
	[FieldOffset(Offset = "0x10")]
	private long m_CurrentTimeMs;

	[Token(Token = "0x4000D55")]
	[FieldOffset(Offset = "0x18")]
	private ValuesFloat m_Floats;

	[Token(Token = "0x4000D56")]
	[FieldOffset(Offset = "0x20")]
	private ValuesInt m_Ints;

	[Token(Token = "0x4000D57")]
	[FieldOffset(Offset = "0x28")]
	private ValuesLength m_Lengths;

	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x30")]
	private ValuesColor m_Colors;

	[Token(Token = "0x4000D59")]
	[FieldOffset(Offset = "0x38")]
	private ValuesEnum m_Enums;

	[Token(Token = "0x4000D5A")]
	[FieldOffset(Offset = "0x40")]
	private ValuesBackground m_Backgrounds;

	[Token(Token = "0x4000D5B")]
	[FieldOffset(Offset = "0x48")]
	private ValuesFontDefinition m_FontDefinitions;

	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0x50")]
	private ValuesFont m_Fonts;

	[Token(Token = "0x4000D5D")]
	[FieldOffset(Offset = "0x58")]
	private ValuesTextShadow m_TextShadows;

	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x60")]
	private ValuesScale m_Scale;

	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x68")]
	private ValuesRotate m_Rotate;

	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x70")]
	private ValuesTranslate m_Translate;

	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x78")]
	private ValuesTransformOrigin m_TransformOrigin;

	[Token(Token = "0x4000D62")]
	[FieldOffset(Offset = "0x80")]
	private ValuesBackgroundPosition m_BackgroundPosition;

	[Token(Token = "0x4000D63")]
	[FieldOffset(Offset = "0x88")]
	private ValuesBackgroundRepeat m_BackgroundRepeat;

	[Token(Token = "0x4000D64")]
	[FieldOffset(Offset = "0x90")]
	private ValuesBackgroundSize m_BackgroundSize;

	[Token(Token = "0x4000D65")]
	[FieldOffset(Offset = "0x98")]
	private readonly List<Values> m_AllValues;

	[Token(Token = "0x4000D66")]
	[FieldOffset(Offset = "0xA0")]
	private readonly Dictionary<StylePropertyId, Values> m_PropertyToValues;

	[Token(Token = "0x6001E94")]
	[Address(RVA = "0x29E9870", Offset = "0x29E8A70", VA = "0x1829E9870")]
	public StylePropertyAnimationSystem()
	{
	}

	[Token(Token = "0x6001E95")]
	private T GetOrCreate<T>(ref T values) where T : new()
	{
		return (T)null;
	}

	[Token(Token = "0x6001E96")]
	private bool StartTransition<T>(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, Values<T> values)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E97")]
	[Address(RVA = "0x29E92A0", Offset = "0x29E84A0", VA = "0x1829E92A0", Slot = "4")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E98")]
	[Address(RVA = "0x29E8ED0", Offset = "0x29E80D0", VA = "0x1829E8ED0", Slot = "5")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E99")]
	[Address(RVA = "0x29E8C20", Offset = "0x29E7E20", VA = "0x1829E8C20", Slot = "6")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E9A")]
	[Address(RVA = "0x29E8CF0", Offset = "0x29E7EF0", VA = "0x1829E8CF0", Slot = "7")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E9B")]
	[Address(RVA = "0x29E8890", Offset = "0x29E7A90", VA = "0x1829E8890", Slot = "8")]
	public bool StartTransitionEnum(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E9C")]
	[Address(RVA = "0x29E8A40", Offset = "0x29E7C40", VA = "0x1829E8A40", Slot = "9")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E9D")]
	[Address(RVA = "0x29E8B40", Offset = "0x29E7D40", VA = "0x1829E8B40", Slot = "10")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E9E")]
	[Address(RVA = "0x29E9450", Offset = "0x29E8650", VA = "0x1829E9450", Slot = "11")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E9F")]
	[Address(RVA = "0x29E9190", Offset = "0x29E8390", VA = "0x1829E9190", Slot = "12")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EA0")]
	[Address(RVA = "0x29E9370", Offset = "0x29E8570", VA = "0x1829E9370", Slot = "13")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EA1")]
	[Address(RVA = "0x29E9090", Offset = "0x29E8290", VA = "0x1829E9090", Slot = "16")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EA2")]
	[Address(RVA = "0x29E9520", Offset = "0x29E8720", VA = "0x1829E9520", Slot = "15")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EA3")]
	[Address(RVA = "0x29E8DD0", Offset = "0x29E7FD0", VA = "0x1829E8DD0", Slot = "14")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0x29E8950", Offset = "0x29E7B50", VA = "0x1829E8950", Slot = "17")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EA5")]
	[Address(RVA = "0x29E9620", Offset = "0x29E8820", VA = "0x1829E9620", Slot = "18")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EA6")]
	[Address(RVA = "0x29E8F90", Offset = "0x29E8190", VA = "0x1829E8F90", Slot = "19")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EA7")]
	[Address(RVA = "0x29E83E0", Offset = "0x29E75E0", VA = "0x1829E83E0", Slot = "20")]
	public void CancelAllAnimations()
	{
	}

	[Token(Token = "0x6001EA8")]
	[Address(RVA = "0x29E84F0", Offset = "0x29E76F0", VA = "0x1829E84F0", Slot = "21")]
	public void CancelAllAnimations(VisualElement owner)
	{
	}

	[Token(Token = "0x6001EA9")]
	[Address(RVA = "0x29E86C0", Offset = "0x29E78C0", VA = "0x1829E86C0", Slot = "22")]
	public void CancelAnimation(VisualElement owner, StylePropertyId id)
	{
	}

	[Token(Token = "0x6001EAA")]
	[Address(RVA = "0x29E96F0", Offset = "0x29E88F0", VA = "0x1829E96F0", Slot = "23")]
	public void UpdateAnimation(VisualElement owner, StylePropertyId id)
	{
	}

	[Token(Token = "0x6001EAB")]
	[Address(RVA = "0x29E8760", Offset = "0x29E7960", VA = "0x1829E8760", Slot = "24")]
	public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds)
	{
	}

	[Token(Token = "0x6001EAC")]
	private void UpdateTracking<T>(Values<T> values)
	{
	}

	[Token(Token = "0x6001EAD")]
	[Address(RVA = "0x1B5CB80", Offset = "0x1B5BD80", VA = "0x181B5CB80")]
	private long CurrentTimeMs()
	{
		return default(long);
	}

	[Token(Token = "0x6001EAE")]
	[Address(RVA = "0x29E9790", Offset = "0x29E8990", VA = "0x1829E9790", Slot = "25")]
	public void Update()
	{
	}
}
