using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Text.RegularExpressions;

public sealed class MatchEvaluator : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_Match_0;

	static MatchEvaluator()
	{
		Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "MatchEvaluator");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr, 100664570);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr, 100664571);
	}

	[CallerCount(142)]
	[CachedScanResults(RefRangeStart = 811721, RefRangeEnd = 811863, XrefRangeStart = 811721, XrefRangeEnd = 811863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MatchEvaluator(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual string Invoke(Match match)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public MatchEvaluator(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator MatchEvaluator(System.Func<Match, string> P_0)
	{
		return DelegateSupport.ConvertDelegate<MatchEvaluator>((System.Delegate)P_0);
	}

	public static MatchEvaluator operator +(MatchEvaluator P_0, MatchEvaluator P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<MatchEvaluator>();
	}

	public static MatchEvaluator operator -(MatchEvaluator P_0, MatchEvaluator P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<MatchEvaluator>();
		}
		return (MatchEvaluator)obj;
	}
}
