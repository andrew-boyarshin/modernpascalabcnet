// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2201 $</version>
// </file>

// This file is automatically generated - any changes will be lost

using System;

#pragma warning disable 1591

namespace PascalSharp.Internal.Debugger.Wrappers.CorDebug
{
    public partial class ICorDebugFunction
	{
		
		private Interop.CorDebug.ICorDebugFunction wrappedObject;
		
		internal Interop.CorDebug.ICorDebugFunction WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugFunction(Interop.CorDebug.ICorDebugFunction wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugFunction));
		}
		
		public static ICorDebugFunction Wrap(Interop.CorDebug.ICorDebugFunction objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugFunction(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugFunction()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugFunction));
		}
		
		public bool Is<T>() where T: class
		{
			System.Reflection.ConstructorInfo ctor = typeof(T).GetConstructors()[0];
			System.Type paramType = ctor.GetParameters()[0].ParameterType;
			return paramType.IsInstanceOfType(this.WrappedObject);
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(ICorDebugFunction o1, ICorDebugFunction o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugFunction o1, ICorDebugFunction o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugFunction casted = o as ICorDebugFunction;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public Wrappers.CorDebug.ICorDebugModule Module
		{
			get
			{
				Wrappers.CorDebug.ICorDebugModule ppModule;
				Interop.CorDebug.ICorDebugModule out_ppModule;
				this.WrappedObject.GetModule(out out_ppModule);
				ppModule = ICorDebugModule.Wrap(out_ppModule);
				return ppModule;
			}
		}
		
		public ICorDebugClass Class
		{
			get
			{
				ICorDebugClass ppClass;
				Interop.CorDebug.ICorDebugClass out_ppClass;
				this.WrappedObject.GetClass(out out_ppClass);
				ppClass = ICorDebugClass.Wrap(out_ppClass);
				return ppClass;
			}
		}
		
		public uint Token
		{
			get
			{
				uint pMethodDef;
				this.WrappedObject.GetToken(out pMethodDef);
				return pMethodDef;
			}
		}
		
		public ICorDebugCode ILCode
		{
			get
			{
				ICorDebugCode ppCode;
				Interop.CorDebug.ICorDebugCode out_ppCode;
				this.WrappedObject.GetILCode(out out_ppCode);
				ppCode = ICorDebugCode.Wrap(out_ppCode);
				return ppCode;
			}
		}
		
		public ICorDebugCode NativeCode
		{
			get
			{
				ICorDebugCode ppCode;
				Interop.CorDebug.ICorDebugCode out_ppCode;
				this.WrappedObject.GetNativeCode(out out_ppCode);
				ppCode = ICorDebugCode.Wrap(out_ppCode);
				return ppCode;
			}
		}
		
		public ICorDebugFunctionBreakpoint CreateBreakpoint()
		{
			ICorDebugFunctionBreakpoint ppBreakpoint;
			Interop.CorDebug.ICorDebugFunctionBreakpoint out_ppBreakpoint;
			this.WrappedObject.CreateBreakpoint(out out_ppBreakpoint);
			ppBreakpoint = ICorDebugFunctionBreakpoint.Wrap(out_ppBreakpoint);
			return ppBreakpoint;
		}
		
		public uint LocalVarSigToken
		{
			get
			{
				uint pmdSig;
				this.WrappedObject.GetLocalVarSigToken(out pmdSig);
				return pmdSig;
			}
		}
		
		public uint CurrentVersionNumber
		{
			get
			{
				uint pnCurrentVersion;
				this.WrappedObject.GetCurrentVersionNumber(out pnCurrentVersion);
				return pnCurrentVersion;
			}
		}
	}
}

#pragma warning restore 1591