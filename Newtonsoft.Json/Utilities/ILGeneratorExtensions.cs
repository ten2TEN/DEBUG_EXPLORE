using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	internal static class ILGeneratorExtensions
	{
		public static void BoxIfNeeded(this ILGenerator generator, Type type)
		{
			if (type.IsValueType())
			{
				generator.Emit(OpCodes.Box, type);
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}

		public static void CallMethod(this ILGenerator generator, MethodInfo methodInfo)
		{
			if (!methodInfo.IsFinal && methodInfo.IsVirtual)
			{
				generator.Emit(OpCodes.Callvirt, methodInfo);
				return;
			}
			generator.Emit(OpCodes.Call, methodInfo);
		}

		public static void PushInstance(this ILGenerator generator, Type type)
		{
			generator.Emit(OpCodes.Ldarg_0);
			if (type.IsValueType())
			{
				generator.Emit(OpCodes.Unbox, type);
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}

		public static void Return(this ILGenerator generator)
		{
			generator.Emit(OpCodes.Ret);
		}

		public static void UnboxIfNeeded(this ILGenerator generator, Type type)
		{
			if (type.IsValueType())
			{
				generator.Emit(OpCodes.Unbox_Any, type);
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}
	}
}