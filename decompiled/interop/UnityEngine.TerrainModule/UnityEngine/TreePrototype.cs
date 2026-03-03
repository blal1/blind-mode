using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class TreePrototype
{
	private delegate bool ValidateTreePrototype_InjectedDelegate(System.IntPtr prototype, [Out] System.IntPtr errorMessage);

	private static readonly ValidateTreePrototype_InjectedDelegate ValidateTreePrototype_InjectedDelegateField = IL2CPP.ResolveICall<ValidateTreePrototype_InjectedDelegate>("UnityEngine.TreePrototype::ValidateTreePrototype_Injected");

	public GameObject prefab
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float bendFactor
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int navMeshLod
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public bool Equals(Il2CppSystem.Object obj)
	{
		return Equals(((Il2CppObjectBase)obj).TryCast<TreePrototype>());
	}

	public override int GetHashCode()
	{
		return ((Il2CppSystem.Object)this).GetHashCode();
	}

	public bool Equals(TreePrototype other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (((Il2CppSystem.Object)this).GetType() != ((Il2CppSystem.Object)(object)other).GetType())
		{
			return false;
		}
		return prefab == other.prefab && bendFactor == other.bendFactor && navMeshLod == other.navMeshLod;
	}

	public bool Validate(out string errorMessage)
	{
		return ValidateTreePrototype(this, out errorMessage);
	}

	public static bool ValidateTreePrototype(TreePrototype prototype, out string errorMessage)
	{
		if (prototype == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)prototype, "prototype");
		}
		Unsafe.SkipInit(out ManagedSpanWrapper errorMessage2);
		try
		{
			return ValidateTreePrototype_Injected(prototype, out errorMessage2);
		}
		finally
		{
			errorMessage = OutStringMarshaller.GetStringAndDispose(errorMessage2);
		}
	}

	public unsafe static bool ValidateTreePrototype_Injected(TreePrototype prototype, out ManagedSpanWrapper errorMessage)
	{
		return ValidateTreePrototype_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prototype), (nint)Unsafe.AsPointer(ref errorMessage));
	}
}
