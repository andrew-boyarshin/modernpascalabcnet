﻿// <file>
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
    public partial class ICorDebugEval
	{
		
		private Interop.CorDebug.ICorDebugEval wrappedObject;
		
		internal Interop.CorDebug.ICorDebugEval WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugEval(Interop.CorDebug.ICorDebugEval wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugEval));
		}
		
		public static ICorDebugEval Wrap(Interop.CorDebug.ICorDebugEval objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugEval(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugEval()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugEval));
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
		
		public static bool operator ==(ICorDebugEval o1, ICorDebugEval o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugEval o1, ICorDebugEval o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugEval casted = o as ICorDebugEval;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void CallFunction(ICorDebugFunction pFunction, uint nArgs, ICorDebugValue[] ppArgs)
		{
			Interop.CorDebug.ICorDebugValue[] array_ppArgs = new Interop.CorDebug.ICorDebugValue[ppArgs.Length];
			for (int i = 0; (i < ppArgs.Length); i = (i + 1))
			{
				if ((ppArgs[i] != null))
				{
					array_ppArgs[i] = ppArgs[i].WrappedObject;
				}
			}
			this.WrappedObject.CallFunction(pFunction.WrappedObject, nArgs, array_ppArgs);
			for (int i = 0; (i < ppArgs.Length); i = (i + 1))
			{
				if ((array_ppArgs[i] != null))
				{
					ppArgs[i] = ICorDebugValue.Wrap(array_ppArgs[i]);
				} else
				{
					ppArgs[i] = null;
				}
			}
		}
		
		public void NewObject(ICorDebugFunction pConstructor, uint nArgs, ref ICorDebugValue ppArgs)
		{
			Interop.CorDebug.ICorDebugValue ref_ppArgs = ppArgs.WrappedObject;
			this.WrappedObject.NewObject(pConstructor.WrappedObject, nArgs, ref ref_ppArgs);
			ppArgs = ICorDebugValue.Wrap(ref_ppArgs);
		}
		
		public void NewObjectNoConstructor(ICorDebugClass pClass)
		{
			this.WrappedObject.NewObjectNoConstructor(pClass.WrappedObject);
		}
		
		public void NewString(string @string)
		{
			this.WrappedObject.NewString(@string);
		}
		
		public void NewArray(uint elementType, ICorDebugClass pElementClass, uint rank, ref uint dims, ref uint lowBounds)
		{
			this.WrappedObject.NewArray(elementType, pElementClass.WrappedObject, rank, ref dims, ref lowBounds);
		}
		
		public int IsActive
		{
			get
			{
				int pbActive;
				this.WrappedObject.IsActive(out pbActive);
				return pbActive;
			}
		}
		
		public void Abort()
		{
			this.WrappedObject.Abort();
		}
		
		public ICorDebugValue Result
		{
			get
			{
				ICorDebugValue ppResult;
				Interop.CorDebug.ICorDebugValue out_ppResult;
				this.WrappedObject.GetResult(out out_ppResult);
				ppResult = ICorDebugValue.Wrap(out_ppResult);
				return ppResult;
			}
		}
		
		public ICorDebugThread Thread
		{
			get
			{
				ICorDebugThread ppThread;
				Interop.CorDebug.ICorDebugThread out_ppThread;
				this.WrappedObject.GetThread(out out_ppThread);
				ppThread = ICorDebugThread.Wrap(out_ppThread);
				return ppThread;
			}
		}
		
		public ICorDebugValue CreateValue(uint elementType, ICorDebugClass pElementClass)
		{
			ICorDebugValue ppValue;
			Interop.CorDebug.ICorDebugValue out_ppValue;
			if (pElementClass != null)
			this.WrappedObject.CreateValue(elementType, pElementClass.WrappedObject, out out_ppValue);
			else 
			this.WrappedObject.CreateValue(elementType, null, out out_ppValue);
			ppValue = ICorDebugValue.Wrap(out_ppValue);
			return ppValue;
		}
	}
}

#pragma warning restore 1591