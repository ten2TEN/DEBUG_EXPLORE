using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	internal static class DynamicUtils
	{
		public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider)
		{
			return dynamicProvider.GetMetaObject(Expression.Constant(dynamicProvider)).GetDynamicMemberNames();
		}

		public static bool TryGetMember(this IDynamicMetaObjectProvider dynamicProvider, string name, out object value)
		{
			ValidationUtils.ArgumentNotNull(dynamicProvider, "dynamicProvider");
			GetMemberBinder member = (GetMemberBinder)DynamicUtils.BinderWrapper.GetMember(name, typeof(DynamicUtils));
			CallSite<Func<CallSite, object, object>> callSite = CallSite<Func<CallSite, object, object>>.Create(new DynamicUtils.NoThrowGetBinderMember(member));
			object target = callSite.Target(callSite, dynamicProvider);
			if (!object.ReferenceEquals(target, DynamicUtils.NoThrowExpressionVisitor.ErrorResult))
			{
				value = target;
				return true;
			}
			value = null;
			return false;
		}

		public static bool TrySetMember(this IDynamicMetaObjectProvider dynamicProvider, string name, object value)
		{
			ValidationUtils.ArgumentNotNull(dynamicProvider, "dynamicProvider");
			SetMemberBinder setMemberBinder = (SetMemberBinder)DynamicUtils.BinderWrapper.SetMember(name, typeof(DynamicUtils));
			CallSite<Func<CallSite, object, object, object>> callSite = CallSite<Func<CallSite, object, object, object>>.Create(new DynamicUtils.NoThrowSetBinderMember(setMemberBinder));
			object target = callSite.Target(callSite, dynamicProvider, value);
			return !object.ReferenceEquals(target, DynamicUtils.NoThrowExpressionVisitor.ErrorResult);
		}

		internal static class BinderWrapper
		{
			public const string CSharpAssemblyName = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			private const string BinderTypeName = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			private const string CSharpArgumentInfoTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			private const string CSharpArgumentInfoFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			private const string CSharpBinderFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			private static object _getCSharpArgumentInfoArray;

			private static object _setCSharpArgumentInfoArray;

			private static MethodCall<object, object> _getMemberCall;

			private static MethodCall<object, object> _setMemberCall;

			private static bool _init;

			private static void CreateMemberCalls()
			{
				Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				Type type1 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				Type type3 = typeof(IEnumerable<>).MakeGenericType(new Type[] { type });
				Type[] typeArray = new Type[] { type1, typeof(string), typeof(Type), type3 };
				MethodInfo method = type2.GetMethod("GetMember", BindingFlags.Static | BindingFlags.Public, null, typeArray, null);
				DynamicUtils.BinderWrapper._getMemberCall = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
				Type[] typeArray1 = new Type[] { type1, typeof(string), typeof(Type), type3 };
				MethodInfo methodInfo = type2.GetMethod("SetMember", BindingFlags.Static | BindingFlags.Public, null, typeArray1, null);
				DynamicUtils.BinderWrapper._setMemberCall = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
			}

			private static object CreateSharpArgumentInfoArray(params int[] values)
			{
				Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				Type type1 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				Array arrays = Array.CreateInstance(type, (int)values.Length);
				for (int i = 0; i < (int)values.Length; i++)
				{
					Type[] typeArray = new Type[] { type1, typeof(string) };
					MethodInfo method = type.GetMethod("Create", BindingFlags.Static | BindingFlags.Public, null, typeArray, null);
					object[] objArray = new object[] { 0, null };
					arrays.SetValue(method.Invoke(null, objArray), i);
				}
				return arrays;
			}

			public static CallSiteBinder GetMember(string name, Type context)
			{
				DynamicUtils.BinderWrapper.Init();
				MethodCall<object, object> methodCall = DynamicUtils.BinderWrapper._getMemberCall;
				object[] objArray = new object[] { 0, name, context, DynamicUtils.BinderWrapper._getCSharpArgumentInfoArray };
				return (CallSiteBinder)methodCall(null, objArray);
			}

			private static void Init()
			{
				if (!DynamicUtils.BinderWrapper._init)
				{
					if (Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", false) == null)
					{
						throw new InvalidOperationException("Could not resolve type '{0}'. You may need to add a reference to Microsoft.CSharp.dll to work with dynamic types.".FormatWith(CultureInfo.InvariantCulture, "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
					}
					DynamicUtils.BinderWrapper._getCSharpArgumentInfoArray = DynamicUtils.BinderWrapper.CreateSharpArgumentInfoArray(new int[1]);
					int[] numArray = new int[] { 0, 3 };
					DynamicUtils.BinderWrapper._setCSharpArgumentInfoArray = DynamicUtils.BinderWrapper.CreateSharpArgumentInfoArray(numArray);
					DynamicUtils.BinderWrapper.CreateMemberCalls();
					DynamicUtils.BinderWrapper._init = true;
				}
			}

			public static CallSiteBinder SetMember(string name, Type context)
			{
				DynamicUtils.BinderWrapper.Init();
				MethodCall<object, object> methodCall = DynamicUtils.BinderWrapper._setMemberCall;
				object[] objArray = new object[] { 0, name, context, DynamicUtils.BinderWrapper._setCSharpArgumentInfoArray };
				return (CallSiteBinder)methodCall(null, objArray);
			}
		}

		internal class NoThrowExpressionVisitor : ExpressionVisitor
		{
			internal readonly static object ErrorResult;

			static NoThrowExpressionVisitor()
			{
				DynamicUtils.NoThrowExpressionVisitor.ErrorResult = new object();
			}

			public NoThrowExpressionVisitor()
			{
			}

			protected override Expression VisitConditional(ConditionalExpression node)
			{
				if (node.IfFalse.NodeType != ExpressionType.Throw)
				{
					return base.VisitConditional(node);
				}
				return Expression.Condition(node.Test, node.IfTrue, Expression.Constant(DynamicUtils.NoThrowExpressionVisitor.ErrorResult));
			}
		}

		internal class NoThrowGetBinderMember : GetMemberBinder
		{
			private readonly GetMemberBinder _innerBinder;

			public NoThrowGetBinderMember(GetMemberBinder innerBinder) : base(innerBinder.Name, innerBinder.IgnoreCase)
			{
				this._innerBinder = innerBinder;
			}

			public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
			{
				DynamicMetaObject dynamicMetaObject = this._innerBinder.Bind(target, new DynamicMetaObject[0]);
				Expression expression = (new DynamicUtils.NoThrowExpressionVisitor()).Visit(dynamicMetaObject.Expression);
				return new DynamicMetaObject(expression, dynamicMetaObject.Restrictions);
			}
		}

		internal class NoThrowSetBinderMember : SetMemberBinder
		{
			private readonly SetMemberBinder _innerBinder;

			public NoThrowSetBinderMember(SetMemberBinder innerBinder) : base(innerBinder.Name, innerBinder.IgnoreCase)
			{
				this._innerBinder = innerBinder;
			}

			public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
			{
				SetMemberBinder setMemberBinder = this._innerBinder;
				DynamicMetaObject[] dynamicMetaObjectArray = new DynamicMetaObject[] { value };
				DynamicMetaObject dynamicMetaObject = setMemberBinder.Bind(target, dynamicMetaObjectArray);
				Expression expression = (new DynamicUtils.NoThrowExpressionVisitor()).Visit(dynamicMetaObject.Expression);
				return new DynamicMetaObject(expression, dynamicMetaObject.Restrictions);
			}
		}
	}
}