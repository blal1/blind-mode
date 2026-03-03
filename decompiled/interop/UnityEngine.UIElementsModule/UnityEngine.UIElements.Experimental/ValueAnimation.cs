using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x20005F5")]
public sealed class ValueAnimation<T> : IValueAnimationUpdate
{
	[Token(Token = "0x40015E1")]
	[FieldOffset(Offset = "0x0")]
	private long m_StartTimeMs;

	[Token(Token = "0x40015E2")]
	[FieldOffset(Offset = "0x0")]
	private int m_DurationMs;

	[Token(Token = "0x40015E8")]
	[FieldOffset(Offset = "0x0")]
	private static ObjectPool<ValueAnimation<T>> sObjectPool;

	[Token(Token = "0x40015ED")]
	[FieldOffset(Offset = "0x0")]
	private T _from;

	[Token(Token = "0x40015EE")]
	[FieldOffset(Offset = "0x0")]
	private bool fromValueSet;

	[Token(Token = "0x17000AAF")]
	public int durationMs
	{
		[Token(Token = "0x6002963")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002964")]
		set
		{
		}
	}

	[Token(Token = "0x17000AB0")]
	public Func<float, float> easingCurve
	{
		[Token(Token = "0x6002965")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002966")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AB1")]
	public bool isRunning
	{
		[Token(Token = "0x6002967")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002968")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000AB2")]
	public Action onAnimationCompleted
	{
		[Token(Token = "0x6002969")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600296A")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AB3")]
	public bool autoRecycle
	{
		[Token(Token = "0x600296B")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600296C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AB4")]
	private bool recycled
	{
		[Token(Token = "0x600296D")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600296E")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AB5")]
	private VisualElement owner
	{
		[Token(Token = "0x600296F")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AB6")]
	public Action<VisualElement, T> valueUpdated
	{
		[Token(Token = "0x6002971")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002972")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AB7")]
	public Func<VisualElement, T> initialValue
	{
		[Token(Token = "0x6002973")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002974")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AB8")]
	public Func<T, T, float, T> interpolator
	{
		[Token(Token = "0x6002975")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002976")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AB9")]
	public T from
	{
		[Token(Token = "0x6002977")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6002978")]
		set
		{
		}
	}

	[Token(Token = "0x17000ABA")]
	public T to
	{
		[Token(Token = "0x6002979")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x600297A")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600297B")]
	public ValueAnimation()
	{
	}

	[Token(Token = "0x600297C")]
	public void Start()
	{
	}

	[Token(Token = "0x600297D")]
	public void Stop()
	{
	}

	[Token(Token = "0x600297E")]
	public void Recycle()
	{
	}

	[Token(Token = "0x600297F")]
	private void UnityEngine_002EUIElements_002EExperimental_002EIValueAnimationUpdate_002ETick(long currentTimeMs)
	{
	}

	[Token(Token = "0x6002980")]
	private void SetDefaultValues()
	{
	}

	[Token(Token = "0x6002981")]
	private void Unregister()
	{
	}

	[Token(Token = "0x6002982")]
	private void Register()
	{
	}

	[Token(Token = "0x6002983")]
	internal void SetOwner(VisualElement e)
	{
	}

	[Token(Token = "0x6002984")]
	private void CheckNotRecycled()
	{
	}

	[Token(Token = "0x6002985")]
	public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator)
	{
		return null;
	}

	[Token(Token = "0x6002986")]
	public ValueAnimation<T> KeepAlive()
	{
		return null;
	}
}
