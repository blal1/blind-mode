using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class ShaderVariantCollection : Object
{
	private delegate void Internal_CreateDelegate(IntPtr svc);

	private delegate int get_shaderCount_InjectedDelegate(IntPtr _unity_self);

	private delegate int get_variantCount_InjectedDelegate(IntPtr _unity_self);

	private delegate int get_warmedUpVariantCount_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_isWarmedUp_InjectedDelegate(IntPtr _unity_self);

	private delegate bool AddVariant_InjectedDelegate(IntPtr _unity_self, IntPtr shader, PassType passType, IntPtr keywords);

	private delegate bool RemoveVariant_InjectedDelegate(IntPtr _unity_self, IntPtr shader, PassType passType, IntPtr keywords);

	private delegate bool ContainsVariant_InjectedDelegate(IntPtr _unity_self, IntPtr shader, PassType passType, IntPtr keywords);

	private delegate void Clear_InjectedDelegate(IntPtr _unity_self);

	private delegate void WarmUp_InjectedDelegate(IntPtr _unity_self);

	private delegate bool WarmUpProgressively_InjectedDelegate(IntPtr _unity_self, int variantCount);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.ShaderVariantCollection::Internal_Create");

	private static readonly get_shaderCount_InjectedDelegate get_shaderCount_InjectedDelegateField = IL2CPP.ResolveICall<get_shaderCount_InjectedDelegate>("UnityEngine.ShaderVariantCollection::get_shaderCount_Injected");

	private static readonly get_variantCount_InjectedDelegate get_variantCount_InjectedDelegateField = IL2CPP.ResolveICall<get_variantCount_InjectedDelegate>("UnityEngine.ShaderVariantCollection::get_variantCount_Injected");

	private static readonly get_warmedUpVariantCount_InjectedDelegate get_warmedUpVariantCount_InjectedDelegateField = IL2CPP.ResolveICall<get_warmedUpVariantCount_InjectedDelegate>("UnityEngine.ShaderVariantCollection::get_warmedUpVariantCount_Injected");

	private static readonly get_isWarmedUp_InjectedDelegate get_isWarmedUp_InjectedDelegateField = IL2CPP.ResolveICall<get_isWarmedUp_InjectedDelegate>("UnityEngine.ShaderVariantCollection::get_isWarmedUp_Injected");

	private static readonly AddVariant_InjectedDelegate AddVariant_InjectedDelegateField = IL2CPP.ResolveICall<AddVariant_InjectedDelegate>("UnityEngine.ShaderVariantCollection::AddVariant_Injected");

	private static readonly RemoveVariant_InjectedDelegate RemoveVariant_InjectedDelegateField = IL2CPP.ResolveICall<RemoveVariant_InjectedDelegate>("UnityEngine.ShaderVariantCollection::RemoveVariant_Injected");

	private static readonly ContainsVariant_InjectedDelegate ContainsVariant_InjectedDelegateField = IL2CPP.ResolveICall<ContainsVariant_InjectedDelegate>("UnityEngine.ShaderVariantCollection::ContainsVariant_Injected");

	private static readonly Clear_InjectedDelegate Clear_InjectedDelegateField = IL2CPP.ResolveICall<Clear_InjectedDelegate>("UnityEngine.ShaderVariantCollection::Clear_Injected");

	private static readonly WarmUp_InjectedDelegate WarmUp_InjectedDelegateField = IL2CPP.ResolveICall<WarmUp_InjectedDelegate>("UnityEngine.ShaderVariantCollection::WarmUp_Injected");

	private static readonly WarmUpProgressively_InjectedDelegate WarmUpProgressively_InjectedDelegateField = IL2CPP.ResolveICall<WarmUpProgressively_InjectedDelegate>("UnityEngine.ShaderVariantCollection::WarmUpProgressively_Injected");

	public int shaderCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shaderCount_Injected(intPtr);
		}
	}

	public int variantCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_variantCount_Injected(intPtr);
		}
	}

	public int warmedUpVariantCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_warmedUpVariantCount_Injected(intPtr);
		}
	}

	public bool isWarmedUp
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isWarmedUp_Injected(intPtr);
		}
	}

	public bool AddVariant(Shader shader, PassType passType, Il2CppStringArray keywords)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return AddVariant_Injected(intPtr, MarshalledUnityObject.Marshal(shader), passType, keywords);
	}

	public bool RemoveVariant(Shader shader, PassType passType, Il2CppStringArray keywords)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return RemoveVariant_Injected(intPtr, MarshalledUnityObject.Marshal(shader), passType, keywords);
	}

	public bool ContainsVariant(Shader shader, PassType passType, Il2CppStringArray keywords)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return ContainsVariant_Injected(intPtr, MarshalledUnityObject.Marshal(shader), passType, keywords);
	}

	public void Clear()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		Clear_Injected(intPtr);
	}

	public void WarmUp()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		WarmUp_Injected(intPtr);
	}

	public bool WarmUpProgressively(int variantCount)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return WarmUpProgressively_Injected(intPtr, variantCount);
	}

	public static void Internal_Create(ShaderVariantCollection svc)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)svc));
	}

	public static int get_shaderCount_Injected(IntPtr _unity_self)
	{
		return get_shaderCount_InjectedDelegateField(_unity_self);
	}

	public static int get_variantCount_Injected(IntPtr _unity_self)
	{
		return get_variantCount_InjectedDelegateField(_unity_self);
	}

	public static int get_warmedUpVariantCount_Injected(IntPtr _unity_self)
	{
		return get_warmedUpVariantCount_InjectedDelegateField(_unity_self);
	}

	public static bool get_isWarmedUp_Injected(IntPtr _unity_self)
	{
		return get_isWarmedUp_InjectedDelegateField(_unity_self);
	}

	public static bool AddVariant_Injected(IntPtr _unity_self, IntPtr shader, PassType passType, Il2CppStringArray keywords)
	{
		return AddVariant_InjectedDelegateField(_unity_self, shader, passType, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keywords));
	}

	public static bool RemoveVariant_Injected(IntPtr _unity_self, IntPtr shader, PassType passType, Il2CppStringArray keywords)
	{
		return RemoveVariant_InjectedDelegateField(_unity_self, shader, passType, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keywords));
	}

	public static bool ContainsVariant_Injected(IntPtr _unity_self, IntPtr shader, PassType passType, Il2CppStringArray keywords)
	{
		return ContainsVariant_InjectedDelegateField(_unity_self, shader, passType, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keywords));
	}

	public static void Clear_Injected(IntPtr _unity_self)
	{
		Clear_InjectedDelegateField(_unity_self);
	}

	public static void WarmUp_Injected(IntPtr _unity_self)
	{
		WarmUp_InjectedDelegateField(_unity_self);
	}

	public static bool WarmUpProgressively_Injected(IntPtr _unity_self, int variantCount)
	{
		return WarmUpProgressively_InjectedDelegateField(_unity_self, variantCount);
	}
}
